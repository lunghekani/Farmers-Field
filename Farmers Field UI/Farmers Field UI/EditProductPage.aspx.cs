using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class EditProductPage : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Add_Status.Visible = false;
            if (!IsPostBack)
            {
                Product p = SC.getProduct(Request.QueryString["A"]);
                Pro_Name.Value = p.Product_Name;
                Pro_Category.Value = p.Product_Category;
                Pro_Description.Value = p.Product_Description;
                pro_ID.Value = Convert.ToString(p.Product_ID);
                Pro_Discount.Value = Convert.ToString(p.Product_Discount);
                Pro_Price.Value = Convert.ToString(p.Product_Price);
                Pro_Supplier.Value = p.Product_Supplier;
            }

        }

        protected void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            Product pro = new Product
            {
                Product_Name = Pro_Name.Value,
                Product_ID = Convert.ToInt32(pro_ID.Value),
                Product_Price = Convert.ToInt32(Pro_Price.Value),
                Product_Supplier = Pro_Supplier.Value,
                Product_Discount = Convert.ToInt32(Pro_Discount.Value),
                Product_Description = Pro_Description.Value,
                Product_Category = Pro_Category.Value
            };

            var AddEditedProduct = SC.editProduct(pro, Convert.ToInt32(Request.QueryString["A"]));
            Add_Status.Visible = true;
            if(Add_Status.Visible == true)
            {
                Pro_Name.Value = "";
                Pro_Category.Value = "";
                Pro_Description.Value = "";
                pro_ID.Value = "";
                Pro_Discount.Value = "";
                Pro_Price.Value = "";
                Pro_Supplier.Value = "";

            }
        }
    }
}