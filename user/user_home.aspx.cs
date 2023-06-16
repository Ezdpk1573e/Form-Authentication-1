using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Form_Authentication_1.user
{
    public partial class user_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["unm"]!= null)
            {
                Label1.Text = Request.Cookies["unm"].Value;
            }
            else
            {
                Response.Redirect("~/Login Form12.aspx");
            }
        }
    }
}