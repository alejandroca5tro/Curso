using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6_3
{
    class Program
    {
        static void Main(string[] args)
        {


            string connectionString = @"Data Source = T06W04\SQLEXPRESS; Initial Catalog = NORTHWND; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string query = "update Products set UnitPrice = UnitPrice + (UnitPrice * 0.02)";
                SqlCommand updateCommand = new SqlCommand(query, connection);
                adapter.UpdateCommand = updateCommand;
                int updatedRows = adapter.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine("{0} filas actualizadas", updatedRows);
                Console.WriteLine();

                string query2 = "select ProductID, ProductName from Products where UnitPrice > @Cantidad";
                SqlCommand comando2 = new SqlCommand(query2, connection);
                comando2.Parameters.AddWithValue("@Cantidad", 50);
                SqlDataReader reader = comando2.ExecuteReader();
                Console.WriteLine("LISTADO MAYORES DE 50");
                Console.WriteLine();

                while (reader.Read())
                {
                    Console.WriteLine("Código {0}", reader["ProductID"].ToString());
                    Console.WriteLine("Código {0}", reader["ProductName"].ToString());
                    Console.WriteLine("________________________________________________");
                }
                Console.ReadKey();
            }
        }
    }
}
