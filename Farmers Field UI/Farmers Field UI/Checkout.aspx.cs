using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Farmers_Field_UI.ServiceReference1;

namespace Farmers_Field_UI
{
    public partial class Checkout : System.Web.UI.Page
    {
        double calcTotal = 0;
        Service1Client service = new Service1Client();
        string identifier = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            identifier = Request.QueryString["ID"];

            if (Session["User"]  == null)
            {
                Response.Redirect("Login.aspx");
            }

            var user = service.getUserByID(Session["User"].ToString());
            first_name.Value = user.first_name;
            last_name.Value = user.last_name;
            address.Value = user.address;
            phone.Value = user.phone_number;
            email.Value = user.email;

            var cart = service.getCartItems(user.User_ID.ToString());

            double cost = 0;
            double disc = 0;
            

            for (int x = 0; x < cart.Length; x++)
            {

                var product_id = cart[x].Product_ID;

                var product = service.getProductByID(product_id);

                cost += Convert.ToDouble(product.Product_Price);
                disc += Convert.ToDouble(product.Product_Discount);
                calcTotal += cost;
            }

            subtotal.InnerHtml = "R " + Math.Round(cost, 2).ToString();

            if(calcTotal >= 1000)
            {
                delivery.InnerHtml = "R " + 0.00;
            }
            else if(calcTotal < 1000)
            {
                delivery.InnerHtml = "R " + 1500.00;
            }

            

            double tax = cost * 0.15;

            vat.InnerHtml = "R " + Math.Round(tax, 2);

            discount.InnerHtml = "R " + Math.Round(disc, 2);

            total.InnerHtml = "R " + Math.Round(cost + 20 + tax, 2).ToString();
        }

        protected void GenerateInvoice(object sender, EventArgs e)
        {
            
            string today_string = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd HH:mm:ss");

            if(service.GenInvoice(Convert.ToInt32(identifier), today_string, calcTotal) == 1)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Cart.aspx");
            }
        }
    }
}