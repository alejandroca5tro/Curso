using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise09_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dAdapter = new SqlDataAdapter("select * from Categories", connection);
                DataTable data = new DataTable();

                dAdapter.Fill(data);
                DataList1.DataSource = data;
                DataList1.DataBind();
            }
        }
    }
}