using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class Wishlist : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();
        string display = "";
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
                items = SC.getWishlist(user.User_ID.ToString());
                
            }
            else
            {
                items = SC.getWishlist(0.ToString());
            }

            foreach (var x in items)
            {
                Product prod = SC.getProductByID(x.Product_ID);

                display += "<tr class='text-center'>";
                display += "<td class='product-remove'><a href = 'RemoveFromWishlist.aspx?ID=" + prod.Product_ID + "' ><span class='ion-ios-close'></span></a></td>";
                display += "<td class='image-prod'><a href='Product-Single.aspx?ID=" + prod.Product_ID + "'><div class='img' style='background-image:url(" + prod.Product_Image + ");'></div></td>"; display += "<td class='product-name'>";
                display += "<h3><a href='Product-Single.aspx?ID="+prod.Product_ID+"'>" + prod.Product_Name + "</a></h3>";
                display += "<p><a href='Product-Single.aspx?ID="+prod.Product_ID+"'>" + prod.Product_Description + "</a></p></td>";
                display += "<td class='price'>R " + Math.Round(prod.Product_Price, 2) + "</td>";
                display += "<td class='quantity'>";
                display += "<div class='input-group mb-3'>";
                display += "<input type = 'text' name='quantity' class='quantity form-control input-number' value='1' min='1' max='100'></div></td>";
                display += "<td class='total'>R " + Math.Round(prod.Product_Price, 2) + "</td></tr>";
            }
            wishlistitems.InnerHtml = display;
        }
    }
}