using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repaso02.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
    }
}