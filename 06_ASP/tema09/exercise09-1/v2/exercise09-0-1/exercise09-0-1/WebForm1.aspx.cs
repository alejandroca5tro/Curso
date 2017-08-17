using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise09_0_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Products where Discontinued = @descuento", connection);

                DataTable data = new DataTable();
                adapter.SelectCommand.Parameters.AddWithValue("@descuento", RadioButtonList1.SelectedValue);

                adapter.Fill(data);

                Repeater1.DataSource = data;
                Repeater1.DataBind();
            }
        }
    }
}