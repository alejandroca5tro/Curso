using repaso02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace repaso02.Controllers
{
    public class ProductoController : Controller
    {
        Producto myProducto = new Producto()
        {
            ProductoId = 1,
            NombreProducto = "Kayak",
            Precio = 234M
        };

        public ActionResult ArrayProductos()
        {
            Producto[] array =
            {
                new Producto {NombreProducto = "Kayak", Precio = 234M, ProductoId = 1 },
                new Producto {NombreProducto = "Piscina", Precio = 238M, ProductoId = 2 },
                new Producto {NombreProducto = "Balón", Precio = 23M, ProductoId = 3 },
                new Producto {NombreProducto = "Portería", Precio = 232M, ProductoId = 4 }
            };

            return View(array);
        }

        // GET: Producto
        public ActionResult Index()
        {
            return View(myProducto);
        }
    }
}