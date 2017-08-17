using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajamar.Datos
{
    public class Empleado
    {
        public static DataTable RecuperarTodosEmpleados()
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            string selectCommand = "select EmployeeID as Cod_Empleado, LastName + ' ' + FirstName as Empleado from Employees";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            return table;
        }
    }
}
