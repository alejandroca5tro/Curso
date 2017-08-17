using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05_DataAdapter
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

                SqlCommand selectCommand =
                    new SqlCommand("SELECT * FROM Customers" +
                    " WHERE Country = @Country AND City = @City", connection);

                selectCommand.Parameters.AddWithValue("@Country", "Argentina");
                selectCommand.Parameters.AddWithValue("@City", "Buenos Aires");

                adapter.SelectCommand = selectCommand;
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1]);
                }
                Console.ReadKey();


                //SqlCommand insertCommand = new SqlCommand("insert into Customers (CustomerID, CompanyName) values (@CustomerId, @CompanyName)", connection);
                //insertCommand.Parameters.AddWithValue("@CustomerId", "Pipas");
                //insertCommand.Parameters.AddWithValue("@CompanyName", "Pipas Facundo");
                //adapter.InsertCommand = insertCommand;
                //int insertedRows = adapter.InsertCommand.ExecuteNonQuery();
                //Console.WriteLine("Filas insertadas {0}", insertedRows);
                //Console.ReadKey();

                SqlCommand updateCommand = new SqlCommand("update Customers set CompanyName = @CompanyName where CustomerID = @oldCustomerId", connection);
                updateCommand.Parameters.AddWithValue("@CompanyName", "Una nueva compañía");
                updateCommand.Parameters.AddWithValue("@oldCustomerID", "PIPAS");
                adapter.UpdateCommand = updateCommand;
                int updatedRows = adapter.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine("Filas actualizadas {0}", updatedRows);
                Console.ReadKey();

                //SqlCommand deleteCommand = new SqlCommand("delete from Customers where CustomerID = @CustomerId", connection);
                //SqlParameter parameter = deleteCommand.Parameters.Add("@CustomerId", SqlDbType.NVarChar, 15);
                //parameter.Value = "PIPAS";
                //adapter.DeleteCommand = deleteCommand;
                //int deletedRows = adapter.DeleteCommand.ExecuteNonQuery();
                //Console.ReadKey();
            }
        }
    }
}
