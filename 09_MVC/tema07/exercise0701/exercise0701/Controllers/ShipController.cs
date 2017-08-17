using exercise0701.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exercise0701.Controllers
{
    public class ShipController : Controller
    {
        // GET: Ship
        public ActionResult Index()
        {
            List<Ship> shipList = CreateFleet();
            var query =
                shipList
                .Select(a => a)
                .OrderByDescending(a => a.BuildingYear);
            return View(query);
        }

        public List<Ship> CreateFleet()
        {
            List<Ship> fleet = new List<Ship>
            {
                new Ship {ShipId=1,ShipName="María Luisa",BuildingYear=2003, BuildingCost=1200, LastRepairDate=Convert.ToDateTime("12/07/2005")},
                new Ship {ShipId=2,ShipName="La Pili",BuildingYear=1997,BuildingCost=2400, LastRepairDate=Convert.ToDateTime("12/10/1999")},
                new Ship {ShipId=3,ShipName="El Torreon",BuildingYear=1993,BuildingCost=1700, LastRepairDate=Convert.ToDateTime("12/07/2005")},
                new Ship {ShipId=4,ShipName="La Niña",BuildingYear=1998,BuildingCost=3100, LastRepairDate=Convert.ToDateTime("10/06/2002")}
            };
            return fleet;
        }
    }
}