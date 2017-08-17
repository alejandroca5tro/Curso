using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "Voy a navegar a una URL y mostrar un mensaje";
        }

        public ViewResult Autoproperty()
        {
            Models.Product product = new Models.Product();
            product.Name = "Kayak";
            string productName = product.Name;
            return View("Result", (object)String.Format("Product Name: {0}", productName));
        }

        public ViewResult CreateProduct()
        {
            Models.Product product = new Models.Product
            {
                Id = 100,
                Name = "Kayak",
                Description = "Un bote para una persona",
                Price = 775M,
                Category = "waterSports"
            };
            return View("Result", (object)String.Format("Product Description: {0}", product.Description));
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "vaca", "perro", "gato" };
            List<int> listOfIntegers = new List<int> { 10, 23, 65 };
            Dictionary<string, int> myDictionary = new Dictionary<string, int> { { "vaca", 10 }, { "perro", 5 }, { "gato", 3 } };
            return View("Result", (object)String.Format("Valor de impresión: {0}", stringArray[1]));
        }

        public ViewResult CreateProductWholeObject()
        {
            Models.Product product = new Models.Product
            {
                Id = 100,
                Name = "Kayak",
                Description = "Un bote para una persona",
                Price = 775M,
                Category = "waterSports"
            };
            return View(product);
        }

        public ViewResult ProductList()
        {
            List<Models.Product> productList = new List<Models.Product>
            {
                new Models.Product {Id=1, Name="Kayak", Category="waterSports", Price=275M },
                new Models.Product {Id=2, Name="Lifejacket", Category="waterSports", Price=48.95M },
                new Models.Product {Id=3, Name="Soccer ball", Category="Soccer", Price=19.50M },
                new Models.Product {Id=4, Name="Kayak", Category="Soccer", Price=34.95M },
            };
            var result = productList
                .Where(p => p.Category == "Soccer")
                .Select(p => p.Price).ToList().Sum();
            return View("Result", (object)String.Format("Este es el resultado de Soccer: {0}", result));
        }

        public ViewResult productListArray()
        {
            Models.Product[] products =
            {
                new Models.Product {Id=1, Name="Kayak", Category="waterSports", Price=275M },
                new Models.Product {Id=2, Name="Lifejacket", Category="waterSports", Price=48.95M },
                new Models.Product {Id=3, Name="Soccer ball", Category="Soccer", Price=19.50M },
                new Models.Product {Id=4, Name="Kayak", Category="Soccer", Price=34.95M },
            };
            var result = products.Sum(p => p.Price);
            products[2] = new Models.Product { Id = 5, Name = "Stadium", Price = 75987M };
            return View("Result", (object)String.Format("Este es el resultado de Soccer: {0}", result));
        }

        public ViewResult productListTake()
        {
            Models.Product[] products =
            {
                new Models.Product {Id=1, Name="Kayak", Category="waterSports", Price=275M },
                new Models.Product {Id=2, Name="Lifejacket", Category="waterSports", Price=48.95M },
                new Models.Product {Id=3, Name="Soccer ball", Category="Soccer", Price=19.50M },
                new Models.Product {Id=4, Name="Kayak", Category="Soccer", Price=34.95M },
            };
            var foundProducts = products.OrderByDescending(p => p.Price)
                .Take(3)
                .Select(p => new
                {
                    p.Name,
                    p.Price
                });
            products[2] = new Models.Product { Id = 5, Name = "Stadium", Price = 75987M };
            StringBuilder result = new StringBuilder();
            foreach (var p in foundProducts)
            {
                result.AppendFormat("Precio {0}", p.Price);
            }
            return View("Result", (object)String.Format("Este es el resultado de Soccer: {0}", result));
        }
    }
}