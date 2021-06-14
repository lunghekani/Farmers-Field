using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        Service1Client SC = new Service1Client();
        string display = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = null;
            

            if (Session["User"] != null)
            {
                user = SC.getUserByID(Session["User"].ToString());
                string identifier = Convert.ToString(user.User_ID);

                LoginLink.Visible = false;
                RegisterLink.Visible = false;
                LogoutLink.Visible = true;
                cartsymbol.Visible = true;
                wishlist.Visible = true;
                cart.Visible = true;
                userhistory.Visible = true;

                string utype = Convert.ToString(user.user_type);

               if(utype == "Manager" && utype != null)
             {
                    manage.Visible = true;
             }
                display += "<li class='nav-item cta cta-colored'><a href = 'Cart.aspx' class='nav-link'><span class='icon-shopping_cart'></span>" + Convert.ToString(SC.GetNumCartItems(identifier)) + "</a></li>";

             
            }
            cartsymbol.InnerHtml = display;
        }
    }
}