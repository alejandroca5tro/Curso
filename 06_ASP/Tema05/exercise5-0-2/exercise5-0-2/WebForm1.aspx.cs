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
            //if (IsPostBack)
            //{
            //    hiddenfield.Value = category.SelectedItem.Text;
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Mediante Response.Redirect:
            string name1 = "";
            string category1 = "";
            string supplier1 = "";
            string unitPrice1 = "";

            name1 = name2.Text;
            category1 = Request.Form["category"];
            supplier1 = Request.Form["supplier"];
            unitPrice1 = Request.Form["unitPrice"];

            Response.Redirect("WebForm2.aspx?name=" + name1 + "&category=" + category1 + "&supplier=" + supplier1 + "&unitPrice=" + unitPrice1);

            //Server.Transfer
            //Server.Transfer("WebForm2.aspx");


        }
    }
}