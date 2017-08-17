using repaso01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace repaso01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Coche myCoche = new Coche();
            myCoche.CocheId = 1;
            myCoche.Descripcion = "Ferrari Testarrosa";

            return View(myCoche);
        }

        public string OtroIndex()
        {
            return "Navegando a la página principal";
        }

        public ActionResult Listado()
        {
            List<int> listadoEnteros = new List<int> { 10, 20, 35, 43 };

            return View(listadoEnteros);            
        }

        public ActionResult viewModel()
        {
            Popurri popu = new Popurri();

            return View(popu);
        }

        public ActionResult OtroMas()
        {
            return View("OtroIndex", (object)"Otra Cadena");
        }
    }
}