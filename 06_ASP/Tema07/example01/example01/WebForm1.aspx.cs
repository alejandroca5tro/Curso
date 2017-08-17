using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            //string query = "select * from employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string categoryName = "Pipas";

                connection.Open();
                SqlCommand command = new SqlCommand("SalesByCategory", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CategoryName";
                parameter.SqlDbType = SqlDbType.NVarChar;

                parameter.Value = categoryName.ToString();
                command.Parameters.Add(parameter);
                int quantity = command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}