using exercise07_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exercise07_1.Controllers
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
                .OrderByDescending(a => a.bul)
            return View();
        }

        public List<Ship> CreateFleet()
        {
            List<Ship> flota = new List<Ship>
            {
                new Ship {BarcoId=1,NombreBarco="María Luisa",AñoConstruccion=2003, CosteConstruccion=1200, FechaUltimaReparacion=Convert.ToDateTime("12/07/2005")},
                new Ship {BarcoId=2,NombreBarco="La Pili",AñoConstruccion=1997,CosteConstruccion=2400, FechaUltimaReparacion=Convert.ToDateTime("12/10/1999")},
                new Ship {BarcoId=3,NombreBarco="El Torreon",AñoConstruccion=1993,CosteConstruccion=1700, FechaUltimaReparacion=Convert.ToDateTime("12/07/2005")},
                new Ship {BarcoId=4,NombreBarco="La Niña",AñoConstruccion=1998,CosteConstruccion=3100, FechaUltimaReparacion=Convert.ToDateTime("10/06/2002")}
            };
            return flota;
        }
    }
}