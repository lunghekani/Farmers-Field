using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class Product_Single : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();
        string display = "";
        string image = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            var identifier = Convert.ToInt32(Request.QueryString["Id"]);
            //display += "<h3>" + identifier + "</h3>";
            dynamic x = SC.getProductByID(identifier);

            if(Session["User"] != null)
            {
                ShowItem(x);
                Signedin(x);
            }
            else
            {
                ShowItem(x);
                NotSignedIn(x);
            }

            
            productimage.InnerHtml = image;
            singleproduct.InnerHtml = display;
        }

        private void ShowItem(dynamic x)
        {
            image += "<a href='images/product-1.jpg' class='image-popup'><img src='" + x.Product_Image + "' class='img-fluid' alt='Colorlib Template'></a>";

            display += "<h3>" + x.Product_Name + "</h3>";
            display += "<div class='d-flex'>";
            display += "<p class='price'><span>R " + Math.Round(x.Product_Price, 2) + "</span></p>";
            display += "</div>";
            display += "<div class='d-flex'>";
            display += "<p>" + x.Product_Description + "</p>";
            display += "</div>";
            display += "<div class='row mt-4'>";
            display += "<div class='col-md-6'>";
            display += "<div class='form-group d-flex'>";
            display += "<div class='select-wrap'>";
            display += "<div class='icon'><span class='ion-ios-arrow-down'></span></div>";
            display += "<div class='w-100'></div>";
            display += "<div class='container'>";
            display += "<label> Quantity </label>";
            display += "<input type = 'text' id='quantity' name='quantity' class='form-control input-number' value='1' min='1' max='100' runat='server'>";
            display += "<div class='w-100'></div>";
            display += "<div class='col-md-12'>";
        }

        private void Signedin(dynamic x)
        {
            display += "<div class='d-flex'>";
            display += "<p><a href = 'AddToCart.aspx?ID=" + x.Product_ID + "' class='btn btn-black py-3 px-5'>Add to Cart</a></p>";
            display += "</div>";
            display += "<div class='d-flex'>";
            display += "<p><a href = 'AddToWishlist.aspx?ID=" + x.Product_ID + "' class='btn btn-black py-3 px-5'>Add to Wishlist</a></p>";
            display += "</div>";
        }

        private void NotSignedIn(dynamic x)
        {
            display += "<div class='container'>";
            display += "<p><a href = 'Checkout.aspx' class='btn btn-black py-3 px-5'>Purchase Item</a></p>";
            display += "<p><a href = 'AddToWishlist.aspx?ID=" + x.Product_ID + "' class='btn btn-black py-3 px-5'>Add to Wishlist</a></p>";
            display += "</div>";
        }
    }
}