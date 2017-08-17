using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exampleDataView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            string query = "select ContactName, Country from Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter dA = new SqlDataAdapter(query, connection);
                DataSet customDataSet = new DataSet();
                dA.Fill(customDataSet, "Customers");
                //Esta tabla podríamos haberla llamado de otro modo ya que esta tabla es una copia de la que hay en la base de datos y va a residir en la memoria caché, pero con un nombre similar es menos complicado trabajar luego.

                DataView customDataView = new DataView(customDataSet.Tables["Customers"], "Country='USA'", "ContactName desc", DataViewRowState.CurrentRows);

                foreach (DataRowView viewRow in customDataView)
                {
                    DataRow row = viewRow.Row;
                    Response.Write("cliente : " + row[0].ToString() + "<br/>");
                }
            }

        }
    }
}