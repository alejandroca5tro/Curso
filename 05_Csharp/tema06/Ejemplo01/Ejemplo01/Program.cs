using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from Customers", conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Console.WriteLine(String.Format("{0} {1}", lector[0], lector[1]));
                //Console.WriteLine(String.Format("{0} {1}", lector[0].ToString(), lector[1].ToString()));
                //Console.WriteLine("{0} {1}", lector[0], lector[1]);
            }
            Console.ReadKey();
        }
    }
}
