using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LE3.Datos
{
    public class Producto
    {
        public static DataTable obtener_Productos()
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "select * from Products";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }        

        public static DataTable obtenerProductoyCantidad(int idProducto)
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "select ProductName, QuantityPerUnit, UnitsInStock from Products where ProductId = "+ idProducto;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
    }
}
