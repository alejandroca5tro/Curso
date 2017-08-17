using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace extraExercise
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_Combo();
            }
        }

        private void cargar_Combo()
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            string query = "select * from Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListItem element = new ListItem();
                    element.Text = reader["ProductName"].ToString();
                    element.Value = reader["ProductID"].ToString();
                    DropDownList1.Items.Add(element);
                }
                connection.Close();
            }
        }

        private void cargar_Datos(string productId)
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("MostExpensive", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@ProductID", SqlDbType.Int);
                parameter.Value = productId;
                command.Parameters.Add(parameter);

                TextBox1.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = DropDownList1.SelectedItem.Value;
            cargar_Datos(value);
        }
    }
}