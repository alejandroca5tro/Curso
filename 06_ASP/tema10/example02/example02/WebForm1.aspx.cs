using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox CustomerID = GridView1.FooterRow.FindControl("CustomerIDTextBox") as TextBox;
            TextBox CompanyName = GridView1.FooterRow.FindControl("CompanyNameTextBox") as TextBox;
            DropDownList ContactTitle = GridView1.FooterRow.FindControl("ContactTitleDropDownList1") as DropDownList;

            SqlDataSource1.InsertParameters["CustomerID"].DefaultValue = CustomerID.Text;
            SqlDataSource1.InsertParameters["CompanyName"].DefaultValue = CompanyName.Text;
            SqlDataSource1.InsertParameters["ContactTitle"].DefaultValue = ContactTitle.SelectedValue.ToString();

            SqlDataSource1.Insert();
        }
    }
}