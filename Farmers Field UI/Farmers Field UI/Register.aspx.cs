using Farmers_Field_UI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farmers_Field_UI
{
    public partial class Register : System.Web.UI.Page
    {
        Service1Client SC = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnRegister(object sender, EventArgs e)
        {
            //Response.Redirect("Login.aspx");
            
            if ((pass.Value).Equals(conf.Value))
            {
                User x = new User();
                x.first_name = firstname.Value;
                x.last_name = lastname.Value;
                x.email = email.Value;
                x.phone_number = number.Value;
                x.address = aadress.Value;
                x.city = city.Value;
                x.province = province.Value;
                x.zip_code = zip.Value;
                x.password = pass.Value;

                if (SC.register(x) == 1)
                {
                    //Response.Redirect("Login.aspx");
                    if (SC.login(x.email, x.password))
                    {
                        Session["User"] = email.Value;
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        firstname.Value = "";
                        lastname.Value = "";
                        email.Value = "";
                        number.Value = "";
                        pass.Value = "";
                    }
                }
                else
                {
                    firstname.Value = "";
                    lastname.Value = "";
                    email.Value = "";
                    number.Value = "";
                    pass.Value = "";
                }
            } else
            {
                Response.Redirect("Register.aspx");
            }
        }
    }
}