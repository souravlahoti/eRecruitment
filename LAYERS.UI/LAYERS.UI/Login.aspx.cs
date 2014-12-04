using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAYERS.UI
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string uname=username.Text;
            string pass = password.Text;


             if (uname == "" || uname == " ") {
                 Response.Write("<script>alert('Username Required');</script>");
             }
             else {
                 if (pass == "" || pass == " ") {
                    Response.Write("<script> alert('Password Required');</script>"); 
                 }
                     else
                     {
                         if (uname== "50009" && pass=="tata1234")
                             Response.Redirect("Page_EditTestStatus.aspx");
                         else if (uname == "742969" && pass=="tata1234")
                             Response.Redirect("TestAdministrator.aspx");
                         else if (uname == "759020" && pass == "tata1234")
                             Response.Redirect("DisplayScheduleTestAdmin.aspx");
                         else if (uname == "730844" && pass=="tata1234")
                             Response.Redirect("CreateCandidate.aspx");
                         else
                             Response.Write("<script> alert('Wrong username or password.');</script>"); 
                       }

                              


                     }
                 }
              
             }
        }

