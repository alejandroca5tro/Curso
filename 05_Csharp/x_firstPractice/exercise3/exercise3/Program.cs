using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabora un sistema capaz de leer la cantidad de cada alimento:
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=HamburgerRestaurant;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                string query = "select Quantity, MenuItemName from MenuItems inner join Orders on MenuItems.MenuItemId = Orders.MenuItemId where OrderId = @OrderId";

                int orderId;
                Console.Write("Introduce el número de pedido que quieres consultar (del 1 al 10): ");
                orderId = Convert.ToInt32(Console.ReadLine());

                SqlCommand selectCommandForFoods = new SqlCommand(query, connection);
                selectCommandForFoods.Parameters.AddWithValue("@OrderId", orderId);
                adapter.SelectCommand = selectCommandForFoods;

                DataTable table = new DataTable();
                adapter.Fill(table);

                Console.WriteLine();
                Console.WriteLine("El pedido {0} contiene:", orderId);
                Console.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine("{0} {1}", row[0], row[1]);
                }
                Console.WriteLine();

                //y calcular la cuenta total de cada pedido de acuerdo al precio de cada uno de los productos:
                query = "select sum(MenuItemPrice) from MenuItems inner join Orders on MenuItems.MenuItemId = Orders.MenuItemId where OrderId = @OrderId";

                SqlCommand selectCommandForTotalCount = new SqlCommand(query, connection);
                selectCommandForTotalCount.Parameters.AddWithValue("@OrderId", orderId);
                adapter.SelectCommand = selectCommandForTotalCount;

                DataSet dsTotalCount = new DataSet();
                adapter.Fill(dsTotalCount);
                string totalCount = dsTotalCount.Tables[0].Rows[0][0].ToString();

                Console.WriteLine("La cuenta total del pedido {0} asciende a {1} euros", orderId, totalCount);
                Console.ReadKey();
            }
        }
    }
}
