using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio9._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["Pepe"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(cadena))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT * FROM Categories", cnn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                DataList1.DataSource = data;
                DataList1.DataBind();

            }

        }
    }
}