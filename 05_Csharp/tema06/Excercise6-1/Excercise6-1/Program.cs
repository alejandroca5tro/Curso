using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = T06W04\SQLEXPRESS; Initial Catalog = NORTHWND; Integrated Security = True";
            string query = "select LastName, FirstName from Employees";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(query, connection);               
                try
                {
                    connection.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    Console.WriteLine("EMPLEADOS DE LA CIUDAD DE LONDRES");
                    Console.WriteLine();
                    while (lector.Read())
                    {                        
                        Console.WriteLine("APELLIDO: {0}", lector[0]);
                        Console.WriteLine("NOMBRE: {0}", lector[1]);
                        Console.WriteLine();
                    }
                    lector.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
