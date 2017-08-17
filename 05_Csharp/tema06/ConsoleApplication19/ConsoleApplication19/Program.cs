using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion =
                @"Data Source=DESKTOP-PT290BD\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            using(SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();

                SqlCommand comandoSelect =
                    new SqlCommand("SELECT * FROM Customers" +
                    " WHERE Country = @Country AND City = @City", conexion);

                comandoSelect.Parameters.AddWithValue("@Country", "Argentina");
                comandoSelect.Parameters.AddWithValue("@City", "Buenos Aires");

                adaptador.SelectCommand = comandoSelect;
                SqlDataReader lector = comandoSelect.ExecuteReader();
                while (lector.Read())
                {
                    Console.WriteLine(lector[0] + " " + lector[1]);
                }


                SqlCommand comandInsert =
                    new SqlCommand("INSERT INTO Customers (CustomerID,CompanyName)" +
                    " VALUES (@CustomerId, @CompanyName)", conexion);
                comandInsert.Parameters.AddWithValue("@CustomerId", "PIPAS");
                comandInsert.Parameters.AddWithValue("@CompanyName", "Pipas Facundo");
                adaptador.InsertCommand = comandInsert;
                int filasInsertadas = adaptador.InsertCommand.ExecuteNonQuery();
                Console.WriteLine("filas insertadas {0}", filasInsertadas);

                SqlCommand comandUpdate =
                    new SqlCommand("UPDATE Customers SET CompanyName = @CompanyName " +
                    " WHERE CustomerID = @oldCustomerID", conexion);
                comandUpdate.Parameters.AddWithValue("@CompanyName", "Una nueva compañía");
                comandUpdate.Parameters.AddWithValue("@oldCustomerID", "PIPAS");
                adaptador.UpdateCommand = comandUpdate;
                int filasActualizadas = adaptador.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine("filas actualizadas {0}", filasActualizadas);

                SqlCommand comandDelete =
                    new SqlCommand("DELETE FROM Customers " +
                    "WHERE CustomerID=@CustomerId", conexion);
                SqlParameter parameter =
                    comandDelete.Parameters.Add("@CustomerId", SqlDbType.NVarChar, 15);
                parameter.Value = "PIPAS";
                adaptador.DeleteCommand = comandDelete;
                int filasBorradas = adaptador.DeleteCommand.ExecuteNonQuery();
                Console.WriteLine("filas borradas {0}", filasBorradas);


                Console.ReadKey();




            }
        }
    }
}
