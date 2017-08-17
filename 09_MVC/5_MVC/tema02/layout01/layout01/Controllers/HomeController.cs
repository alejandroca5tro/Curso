using example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace layout01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        Product myProduct = new Product
        {
            Id = 1,
            Name = "Kayak",
            Description = "A boat for one person",
            Price = 275M,
            Category = "WaterSports"
        };

        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Suppliers = "";
            return View(myProduct);
        }
        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name="Kayak", Price=275M },
                new Product {Name="Lifejacket", Price=48.95M },
                new Product {Name="Soccer Ball", Price }
            }
        }
    }
}