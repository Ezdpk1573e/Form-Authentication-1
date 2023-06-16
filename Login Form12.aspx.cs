using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace Form_Authentication_1
{
    public partial class Login_Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "DEV" && TextBox2.Text == "sy")
            {
                //    //FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
                //    // Response.Redirect("~/Admin/Home Page.aspx");
                //HttpCookie ck = new HttpCookie("unm");
                //ck.Value = TextBox1.Text;
                //if (CheckBox1.Checked)
                //    ck.Expires = DateTime.Now.AddMinutes(1);

                //Response.Cookies.Add(ck);
                //Response.Redirect("~/user/user_home.aspx");
                Session["unm"] = TextBox1.Text;
                Response.Redirect("~/user/session.aspx");

            }
            else
            {
                Response.Write("Invalid User");
            }


        }
    }
}