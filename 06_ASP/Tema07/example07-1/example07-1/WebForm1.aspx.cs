using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example07_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cargar_Datos();
        }

        private void cargar_Datos()
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UnidadesStock", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@ProductID", SqlDbType.Int);
                parameter.Value = Convert.ToInt32(txtProductId.Text);
                command.Parameters.Add(parameter);

                txtUnidades.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
        }
    }
}