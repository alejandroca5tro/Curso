using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = T06W04\SQLEXPRESS; Initial Catalog = NORTHWND; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select E.LastName + ' ' + E.FirstName AS Nombre, E.Address, E.City from Employees as E where City = @City";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@City", "London");

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                SqlDataReader reader = command.ExecuteReader();

                StreamWriter file;
                file = File.CreateText("Empleados.txt");
                file.WriteLine("Empleados de Londres");
                while (reader.Read())
                {
                    file.WriteLine(reader["Nombre"].ToString() + "(" + reader["Address"].ToString() + ")" + reader["City"].ToString());
                }

                file.Close();
                reader.Close();
                connection.Close();

                Console.WriteLine("Datos transferidos con éxito, pulse intro para continuar");

                Console.ReadKey();
            }
            
        }
    }
}
