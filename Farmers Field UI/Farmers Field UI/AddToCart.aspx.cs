using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class AddToCart : System.Web.UI.Page
    {
        Service1Client SR = new Service1Client();
    
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var identifier = Convert.ToInt32(Request.QueryString["Id"]);

            //Product item = SR.getProductByID(identifier);

            var user = SR.getUserByID(Session["User"].ToString());

            if (user != null)
            {
                SR.addToCart(identifier, user.User_ID.ToString());
            } else
            {
                SR.addToCart(identifier, 0.ToString());
            }

            System.Diagnostics.Debug.WriteLine("Product added to cart by user ");

            //string urlName = Request.UrlReferrer.ToString();

            Response.Redirect("Product-Single.aspx?ID="+identifier+"");
        }
    }
}