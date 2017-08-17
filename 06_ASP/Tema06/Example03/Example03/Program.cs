using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        private static void UpdateRegion(int regionId, string regionDescription, string connectionString)
        {
            string query = "update Region set RegionDescription = @Region where RegionID = @Code";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@Code", SqlDbType.Int);
                command.Parameters["@Code"].Value = regionId;

                command.Parameters.AddWithValue("@Region", regionDescription);

                try
                {
                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();
                    Console.WriteLine("Filas afectadas: {0}", affectedRows);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            Console.WriteLine("ID de región a modificar: ");
            int regionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Descripción de la región: ");
            string regionDescription = Console.ReadLine();

            UpdateRegion(regionId, regionDescription, connectionString);

            Console.ReadKey();
        }
    }
}
