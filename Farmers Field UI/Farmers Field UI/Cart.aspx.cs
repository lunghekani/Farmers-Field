using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class Cart : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();

        string display = "";

        double calcsubt = 0;
        double calcvat = 0;
        double calcdelivery = 0;
        double calcdiscount = 0;
        double calctotal = 0;

        int cartinstance = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            User user = null;

            if (Session["User"] != null)
            {
                user = SC.getUserByID(Session["User"].ToString());
            }

            dynamic items = null;

            if (user != null)
            {
                System.Diagnostics.Debug.WriteLine("Getting carts items for user " + Session["User"]);
                items = SC.getCartItems(user.User_ID.ToString());
                cartinstance = SC.GetCart(user.User_ID);
            }
    
            foreach (var x in items)
            {
                Product prod = SC.getProductByID(x.Product_ID);

                display += "<tr class='text-center'>";
                display += "<td class='product-remove'><a href = 'RemoveFromCart.aspx?ID=" + prod.Product_ID + "' ><span class='ion-ios-close'></span></a></td>";
                display += "<td class='image-prod'><a href='Product-Single.aspx?ID=" + prod.Product_ID + "'><div class='img' style='background-image:url(" + prod.Product_Image + ");'></div></td>";
                display += "<td class='product-name'>";
                display += "<h3><a href='Product-Single.aspx?ID=" + prod.Product_ID + "'>" + prod.Product_Name + "</h3>";
                display += "<p><a href='Product-Single.aspx?ID=" + prod.Product_ID + "'>" + prod.Product_Description + "</p></td>";
                display += "<td class='price'>R " + Math.Round(prod.Product_Price, 2) + "</td>";
                display += "<td class='quantity'>";
                display += "<div class='input-group mb-3'>";
                display += "<input type = 'text' name='quantity' class='quantity form-control input-number' value='1' min='1' max='100'></div></td>";
                display += "<td class='total'>R " + Math.Round(prod.Product_Price, 2) + "</td></tr>";
                calcsubt += Convert.ToDouble(prod.Product_Price);
                calcdiscount += Convert.ToDouble(prod.Product_Discount);
            }

            subtotal.InnerHtml += "<span>R"+Convert.ToString(calcsubt)+"</span>";

            calcvat = ((calcsubt + 100) * 0.15);
            vat.InnerHtml +="<span>R"+ Convert.ToString(Math.Round(calcvat,2)) + "</span>";

            if(calcsubt > 10000)
            {
                calcdelivery = 0;
            }
            else
            {
                calcdelivery = 100;
            }
            delivery.InnerHtml += "<span>R"+Convert.ToString(calcdelivery)+"</span>";


            discount.InnerHtml += "<span>R"+Convert.ToString(calcdiscount)+"</span>";

            calctotal = ((calcsubt + calcdelivery + calcvat) - calcdiscount);

            total.InnerHtml += "<span>R"+Convert.ToString(calctotal)+"</span>";
            cartitems.InnerHtml = display;


        }

        protected void GoToCheckout(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx?ID=" + cartinstance + "");
        }
    }
}