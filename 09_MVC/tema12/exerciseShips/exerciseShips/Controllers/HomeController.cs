using exerciseShips.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exerciseShips.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ////Forma 1 de llenar el combo (ViewBag usando el mismo nombre)
            //FillComboWay1();            
            //return View();

            ////Forma 2 de llenar el combo (ViewBag usando nombres distintos)
            //FillComboWay2();
            //return View();

            //Forma 3 de llenar el combo (Usando DropDownListFor)
            var vm = new VMComboShips();
            vm.Ships = ships;
            return View(vm);
        }

        private List<Ship> ships = new List<Ship>
        {
            new Ship {BarcoId=1,NombreBarco="María Luisa",AñoConstruccion=2003, CosteConstruccion=1200, FechaUltimaReparacion=Convert.ToDateTime("12/07/2005")},
            new Ship {BarcoId=2,NombreBarco="La Pili",AñoConstruccion=1997,CosteConstruccion=2400, FechaUltimaReparacion=Convert.ToDateTime("12/10/1999")},
            new Ship {BarcoId=3,NombreBarco="El Torreon",AñoConstruccion=1993,CosteConstruccion=1700, FechaUltimaReparacion=Convert.ToDateTime("12/07/2005")},
            new Ship {BarcoId=4,NombreBarco="La Niña",AñoConstruccion=1998,CosteConstruccion=3100, FechaUltimaReparacion=Convert.ToDateTime("10/06/2002")}
        };

        ////Forma 1 de llenar el combo (ViewBag usando el mismo nombre)
        //private void FillComboWay1()
        //{
        //    var items = new List<SelectListItem>();
        //    items =
        //        ships.
        //        Select(s => new SelectListItem()
        //        {
        //            Text = s.NombreBarco,
        //            Value = s.BarcoId.ToString()
        //        }).ToList();

        //    ViewBag.Ships = items;
        //}

        //[HttpPost]
        //public ActionResult Index(string Ships)
        //{
        //    var id = Int32.Parse(Ships);

        //    var ship = ships.FirstOrDefault(s => s.BarcoId == id);
        //    return View();
        //}

        ////Forma 2 de llenar el combo (ViewBag usando nombres distintos)
        //private void FillComboWay2()
        //{
        //    var items = ships;
        //    ViewBag.Ships = new SelectList(items, "BarcoId", "NombreBarco");
        //}
        //[HttpPost]
        //public ActionResult Index(string selectedShip)
        //{
        //    var id = Int32.Parse(selectedShip);

        //    var city = ships.FirstOrDefault(s => s.BarcoId == id);
        //    return View();
        //}


        //Forma 3 de llenar el combo (Usando DropDownListFor)
        [HttpPost]
        public ActionResult Index(VMComboShips info)
        {
            var id = info.SelectedShip;

            var city = ships.FirstOrDefault(s => s.BarcoId == id);
            return View();
        }
    }
}