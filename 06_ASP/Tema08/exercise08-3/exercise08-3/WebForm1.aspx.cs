using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise08_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            string query = "select ProductName, UnitsInStock from Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter dA = new SqlDataAdapter(query, connection);
                DataSet customDataSet = new DataSet();
                dA.Fill(customDataSet, "Products");

                DataView customDataView = new DataView(customDataSet.Tables["Products"], "UnitsInStock>50", "UnitsInStock asc", DataViewRowState.CurrentRows);

                Response.Write("Producto - Unidades en stock" + "<br/>");
                Response.Write("<br/>");

                //¿Y si queremos obtener el número total de registros? Podríamos hacerlo de varias formas:
                //Opción a) Incluir un contador en el foreach

                int contador = 0;
                foreach (DataRowView viewRow in customDataView)
                {
                    contador++;
                    DataRow row = viewRow.Row;

                    Response.Write(row[0].ToString() + " - " + row[1].ToString() +" ud.<br/>");
                }
                Response.Write("<br/>");
                Response.Write("El número total de registros es: " + contador + "<br/>");

                //Opción b) hacer otra consulta.
            }

        }
    }
}