using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlDataAdapter dAEmployees = new SqlDataAdapter("select * from Employees", connection);

            DataSet dSEnterprise = new DataSet("Empresa");
            dAEmployees.Fill(dSEnterprise, "Empleados");

            DataTable tableEmployees = dSEnterprise.Tables["Empleados"];

            foreach (DataRow rows in tableEmployees.Rows)
            {
                Console.WriteLine("{0} {1}", rows[0], rows[1]);
            }
            Console.ReadKey();
        }
    }
}
