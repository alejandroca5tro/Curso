using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise09_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Selecciona un empleado");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView1 = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);

            foreach (DataRowView dRV in dataView1)
            {
                this.TextBox1.Text = dRV["EmployeeID"].ToString();
                this.TextBox2.Text = dRV["FirstName"].ToString();
                this.TextBox3.Text = dRV["LastName"].ToString();
                this.TextBox4.Text = dRV["Title"].ToString();
            }
        }
    }
}