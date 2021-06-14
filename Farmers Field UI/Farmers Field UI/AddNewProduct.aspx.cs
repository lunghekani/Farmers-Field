using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class AddNewProduct : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Add_Status.Visible = false;
            addstatus.Visible = false;

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

           Product pro = new Product();
            pro.Product_ID = Convert.ToInt32(pro_ID.Value);
            pro.Product_Category = Pro_Category.Value;
            pro.Product_Name = Pro_Name.Value;
            pro.Product_Description = Pro_Description.Value;
            pro.Product_Price = Convert.ToInt32(Pro_Price.Value);
            pro.Product_Discount = Convert.ToInt32(Pro_Discount.Value);
            pro.Product_Supplier = Pro_Supplier.Value;

            bool isAdded = SC.AddProduct(pro);

            if (isAdded == true)
            {
                pro_ID.Value = "";
                Pro_Name.Value = "";
                Pro_Category.Value = "";
                Pro_Description.Value = "";
                Pro_Discount.Value = "";
                Pro_Price.Value = "";
                Pro_Supplier.Value = "";

                Add_Status.Visible = true;
            }
           else
            {
                pro_ID.Value = "";
                Pro_Name.Value = "";
                Pro_Category.Value = "";
                Pro_Description.Value = "";
                Pro_Discount.Value = "";
                Pro_Price.Value = "";
                Pro_Supplier.Value = "";
                addstatus.Visible = true;
            }


        }
    }
}