using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise07_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Generar_Transaccion();
        }

        private void Generar_Transaccion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            string query1, query2;

            query1 = "delete from Customers where Country='" + txtPais.Text + "'";
            query2 = "update Products set [UnitPrice]=[UnitPrice] + 2 where UnitsInStock>20";

            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query1, connection);
                    int result1 = command.ExecuteNonQuery();
                    Response.Write("Registros borrados + " + result1);
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query1, connection);
                    int result2 = command.ExecuteNonQuery();
                    Response.Write("Registros actualizados + " + result2);
                }
                ts.Complete();
            }
        }
    }
    
 }