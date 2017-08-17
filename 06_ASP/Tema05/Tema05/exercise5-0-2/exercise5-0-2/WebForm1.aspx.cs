using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise5_0_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = "";
            string category = "";
            string supplier = "";
            string unitPrice = "";

            name = Request.Form["name"];
            category = Request.Form["category"];
            supplier = Request.Form["supplier"];
            unitPrice = Request.Form["unitPrice"];

            Response.Redirect("WebForm2.aspx?name=" + name + "&category=" + category + "&supplier=" + supplier + "&unitPrice=" + unitPrice);
        }
    }
}