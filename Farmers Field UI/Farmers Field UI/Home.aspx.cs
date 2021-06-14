using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class Index : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            /**dynamic products = SC.getAllProducts();

            String display = "";

            foreach (Product x in products)
            {
                display += "<div class='col-md-6 col-lg-3 ftco-animate'>";
                display += "<div class='product'>";
                display += "<a href ='Product-Single.aspx?ID=" + x.Product_ID + "' class='img-prod'><img class='img-fluid' src='" + x.Product_Image + "' alt='Colorlib Template'>";
                display += "<span class='status'>30%</span>";
                display += "<div class='overlay'></div></a>";
                display += "<div class='text py-3 pb-4 px-3 text-center'>";
                display += "<h3><a href = 'Product-Single.aspx?ID=" + x.Product_ID + "' >" + x.Product_Name + "</a></h3>";
                display += "<div class='d-flex'>";
                display += "<div class='pricing'>";
                display += "<p class='price'><span>R " + Math.Round(x.Product_Price, 2) + "</span></p>";
                //display += "<p class='price'><span class='mr-2 price-dc'>$120.00</span><span class='price-sale'>$80.00</span></p></div></div>";
                display += "<div class='bottom-area d-flex px-3'>";
                display += "<div class='m-auto d-flex'>";
                display += "<a href = 'AddToCart?=" + x.Product_ID + "' class='add-to-cart d-flex justify-content-center align-items-center text-center'>";
                display += "<span><i class='ion-ios-menu'></i></span></a>";
                display += "<a href = '#' class='buy-now d-flex justify-content-center align-items-center mx-1'>";
                display += "<span><i class='ion-ios-cart'></i></span></a>";
                display += "<a href = 'AddToWishlist.aspx?=" + x.Product_ID + "' class='heart d-flex justify-content-center align-items-center'>";
                display += "<span><i class='ion-ios-heart'></i></span></a></div></div></div></div></div></div></div>";
            }

            prodcuctlisting.InnerHtml = display;*/
        } 
    }
}