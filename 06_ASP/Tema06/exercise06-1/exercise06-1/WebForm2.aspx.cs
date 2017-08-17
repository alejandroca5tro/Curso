using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise06_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fullName;
            fullName = Request.Form["ctl00$cuerpo$txtName"] + " " + Request.Form["ctl00$cuerpo$txtLastName"];
            txtConcatenatedName.Text = fullName;
        }
    }
}