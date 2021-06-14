using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class InvoicePage : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();
        string display = "";
        User user = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                user = SC.getUserByID(Session["User"].ToString());
            }
        }

        protected void btnInvoice(object sender, EventArgs e)
        {
            Invoice inv = SC.getInvoiceByID(Convert.ToInt32(invoiceid.Value));

            if(inv != null)
            {
                date.Visible = true;
                date.Value = "Date: " +inv.Date_Of_Issue;

                totalsum.Visible = true;
                totalsum.Value = "Total: " +Convert.ToString(inv.Invoice_Total);
            }
        }
    }
}