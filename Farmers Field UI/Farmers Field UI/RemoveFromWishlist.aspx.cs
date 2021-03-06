using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class RemoveFromWishlist : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            var identifier = Convert.ToInt32(Request.QueryString["ID"]);

            var user = SC.getUserByID(Session["User"].ToString());

            if (user != null)
            {
                SC.RemoveFromWishList(identifier, user.User_ID.ToString());
            }
            else
            {
                SC.RemoveFromWishList(identifier, 0.ToString());
            }

            System.Diagnostics.Debug.WriteLine("Product added to cart by user ");

            Response.Redirect("Wishlist.aspx?ID=" + identifier + "");
        }
    }
}