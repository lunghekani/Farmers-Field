using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class GetProduct : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            var pr = SC.FindProductBeingSearched_ID(pro_ID.Value);

            if (pr > 0)
            {
                if(SC.removeProduct(pr))
                {
                    Add_Status.Visible = true;
                }
                else
                {
                    Div1.Visible = true;
                }
            }
        }
    }
}