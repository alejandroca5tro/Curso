using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LE3.Negocio
{
    public class Producto
    {
        public static DataTable obtener_Productos()
        {
            DataTable table = Datos.Producto.obtener_Productos();
            return table;
        }

        public static DataTable obtenerProductoyCantidad(int idProducto)
        {
            DataTable table = Datos.Producto.obtenerProductoyCantidad(idProducto);
            //Regla de negocio
            if (Convert.ToInt32(table.Rows[0][1]) > 50) 
            {
                return table;
            }
            else
            {
                return null;
            }            
        }
    }
}