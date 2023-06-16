using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Form_Authentication_1.user
{
    public partial class session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["unm"] != null)
            {
                Label1.Text = Session["unm"].ToString();
                Session.Timeout = 1;

            }
            else
            {
                Response.Redirect("~/Login Form12.aspx");
            }
        }
    }
}