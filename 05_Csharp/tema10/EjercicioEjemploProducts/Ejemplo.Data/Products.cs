using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Data
{
    public class Products
    {
        public static DataTable retrieveProductData()
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            string selectCommand = "select * from Products";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
    }
}
