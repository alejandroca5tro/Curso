using exercise02_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace exercise02_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult CreateCar()
        {
            Car myCar = new Car();
            myCar.Color = "Rojo";
            myCar.Brand = "Porsche";
            myCar.Model = "911";

            return View("Result", (object)String.Format("Coche: {0} Modelo {1}", myCar.Brand, myCar.Model));
        }

        public ViewResult CreateClients()
        {
            string[] client = { "Juan", "Andrés", "Julián" };
            return View("Result", (object)client[1]);
        }

        public ViewResult CreateCarArray()
        {
            Car[] cars =
            {
                new Car {Color="Rojo", Brand="Fiat", Model="Panda" },
                new Car {Color="Verde", Brand="Renault", Model="Cangoo" },
                new Car {Color="Azul", Brand="Citroen", Model="C5" },
            };
            var choosenCars = cars.OrderByDescending(c => c.Brand)
                .Take(2)
                .Select(c => new
                {
                    c.Color,
                    c.Brand,
                    c.Model
                });
            StringBuilder result = new StringBuilder();
            foreach (var r in choosenCars)
            {
                result.AppendFormat("Color: {0}", r.Color);
                result.AppendFormat("Marca: {0}", r.Brand);
                result.AppendFormat("Modelo: {0}", r.Model);
            }
            return View("Result", (object)result.ToString());
        }

        public ViewResult averageCars()
        {
            Car[] cars =
            {
                new Car {Color="Rojo", Brand="Fiat", Model="Panda", Price=30000 },
                new Car {Color="Verde", Brand="Renault", Model="Cangoo", Price=34000 },
                new Car {Color="Azul", Brand="Citroen", Model="C5", Price=26000 },
            };
            var average = cars.Average(c => c.Price);
            return View("Result", (object)average.ToString());
        }
    }
}