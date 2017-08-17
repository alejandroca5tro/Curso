using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise08_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select ContactName, Address from Customers where City = 'London' order by ContactName";

            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
            adapter.Fill(data);

            DataTableReader reader = data.CreateDataReader();

            while (reader.Read())
            {
                Response.Write(reader["ContactName"]);
                Response.Write("<br/>");
                Response.Write(reader["Address"]);
                Response.Write("<hr/>");
            }
            reader.Close();
        }
    }
}