using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class Login : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool userExists = SC.login(username.Value, pass.Value);
            if (userExists == true)
            {
                //User x = SC.getUserByID();
                User u  = SC.GetUser(username.Value);
                Session["User"] = username.Value;
                Session["UserType"] = u.user_type;

                Response.Redirect("Home.aspx");
            }
            else
            {
                username.Value = "";
                pass.Value = "";
            }
        }
    }
}