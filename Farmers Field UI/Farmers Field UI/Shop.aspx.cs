using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class Shop : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();
        string display = "";
        string interior = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic products = SC.getAllProducts();

            foreach (Product x in products)
            {
                interior += DisplayItems(x, display);
            }
            shopproducts.InnerHtml = interior;
        }

        protected void btnAll(object sender, EventArgs e)
        {

            interior = "";

            dynamic food = SC.getAllProducts();

            foreach (Product x in food)
            {
                interior += DisplayItems(x, display);
            }

            shopproducts.InnerHtml = interior;
        }

        protected void btnFood(object sender, EventArgs e)
        {

            interior = "";

            dynamic food = SC.getAllProdcutsByType("Food");

            foreach (Product x in food)
            {
               interior += DisplayItems(x, display);
            }

            shopproducts.InnerHtml = interior;
        }

        protected void btnMachinary(object sender, EventArgs e)
        {
            interior = "";

            dynamic food = SC.getAllProdcutsByType("Machinary");

            foreach (Product x in food)
            {
                interior += DisplayItems(x, display);
            }

            shopproducts.InnerHtml = interior;
        }

        protected void btnMeds(object sender, EventArgs e)
        {
            interior = "";

            dynamic food = SC.getAllProdcutsByType("Medication");

            foreach (Product x in food)
            {
                interior += DisplayItems(x, display);
            }

            shopproducts.InnerHtml = interior;
        }

        private string DisplayItems(Product x, string display)
        {
            display += "<div class='col-md-6 col-lg-3 ftco-animate'>";
            display += "<div class='product'>";
            display += "<a href = 'Product-Single.aspx?ID="+x.Product_ID+"' class='img-prod'><img class='img-fluid' src='" + x.Product_Image + "' alt='Colorlib Template'>";
            display += "<div class='overlay'></div></a>";
            display += "<div class='text py-3 pb-4 px-3 text-center'>";
            display += "<h3><a href = 'Product-Single.aspx?ID="+x.Product_ID+"'>" + x.Product_Name + "</a></h3>";
            display += "<div class='d-flex'>";
            display += "<div class='pricing'>";
            display += "<p class='price'><span>R " + Math.Round(x.Product_Price, 2) + "</span></p></div></div></div>";
            display += "<div class='bottom-area d-flex px-3'>";
            display += "<div class='m-auto d-flex'>";
            display += "<a href = '#' class='add-to-cart d-flex justify-content-center align-items-center text-center'>";
            display += "<span><i class='ion-ios-menu'></i></span></a>";
            display += "<a href = '#' class='buy-now d-flex justify-content-center align-items-center mx-1'>";
            display += "<span><i class='ion-ios-cart'></i></span></a>";
            display += "<a href = '#' class='heart d-flex justify-content-center align-items-center'>";
            display += "<span><i class='ion-ios-heart'></i></span></a></div></div></div></div>";

            return display;
        }
    }
}