using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6_2_otraOp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dAProducts = new SqlDataAdapter("select ProductID, ProductName from Products", connection);
                    DataSet dSEnterprise = new DataSet("Empresa");
                    dAProducts.Fill(dSEnterprise, "Productos");
                    DataTable tableProducts = dSEnterprise.Tables["Productos"];
                    Console.WriteLine("LISTADO DE PRODUCTOS:");
                    Console.WriteLine();
                    foreach (DataRow rows in tableProducts.Rows)
                    {
                        Console.WriteLine("Número: {0}", rows[0]);
                        Console.WriteLine("Producto: {0}", rows[1]);
                        Console.WriteLine();
                    }
                    Console.ReadKey();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
