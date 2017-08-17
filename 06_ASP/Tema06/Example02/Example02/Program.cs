using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source = T06W04\SQLEXPRESS; Initial Catalog = NORTHWND; Integrated Security = True";
            string consulta = "select ProductID, ProductName, UnitPrice from Products where UnitPrice> @precio and UnitsInStock > @unidades order by UnitPrice desc";
            //int paramValue = 50;

            Console.WriteLine("Precio a mostrar: ");
            int priceValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unidades en stock: ");
            int unitsValue = Convert.ToInt32(Console.ReadLine());


            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@precio", priceValue);
                comando.Parameters.AddWithValue("@unidades", unitsValue);
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", lector[0], lector[1], lector[2]);
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
