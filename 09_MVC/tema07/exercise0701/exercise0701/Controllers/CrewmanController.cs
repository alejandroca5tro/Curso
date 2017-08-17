using exercise0701.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exercise0701.Controllers
{
    public class CrewmanController : Controller
    {
        // GET: Crewman
        public ActionResult Index(int id, string name)
        {
            List<Crewman> crewmanList = CreateCrew();
            var query =
                crewmanList
                .Where(c => c.ShipId.Equals(id))
                .Select(c => c)
                .ToList();
            ViewBag.Ship = name.ToUpper();
            return View(query);
        }

        public List<Crewman> CreateCrew()
        {
            List<Crewman> crew = new List<Crewman>
            {
                new Crewman {CrewmanId=1,CrewmanName="David",Position="Contramaestre",NavigationTitleDate=Convert.ToDateTime("05/08/1999"), ShipId=1},
                new Crewman {CrewmanId=2,CrewmanName="Felix",Position="Almirante",NavigationTitleDate=Convert.ToDateTime("05/09/2001"), ShipId=2},
                new Crewman {CrewmanId=3,CrewmanName="Ricardo",Position="Marinero",NavigationTitleDate=Convert.ToDateTime("08/08/1988"),ShipId=1},
                new Crewman {CrewmanId=4,CrewmanName="Elena",Position="Marinero",NavigationTitleDate=Convert.ToDateTime("16/08/1999"),ShipId=3},
                new Crewman {CrewmanId=5,CrewmanName="Susana",Position="Sobrecargo",NavigationTitleDate=Convert.ToDateTime("17/10/2002"),ShipId=1},
                new Crewman {CrewmanId=6,CrewmanName="Javier",Position="Marinero 1ª",NavigationTitleDate=Convert.ToDateTime("05/08/2001"),ShipId=4},
                new Crewman {CrewmanId=7,CrewmanName="Federico",Position="Marinero 2ª",NavigationTitleDate=Convert.ToDateTime("19/01/1999"),ShipId=4},
                new Crewman {CrewmanId=8,CrewmanName="Inmaculada",Position="Piloto",NavigationTitleDate=Convert.ToDateTime("17/10/2003"),ShipId=4}

            };
            return crew;
        }

        public List<Ship> CrearFlota()
        {
            List<Ship> fleet = new List<Ship>
            {
                new Ship {ShipId=1,ShipName="María Luisa",BuildingYear=2003, BuildingCost=1200, LastRepairDate=Convert.ToDateTime("12/07/2005")},
                new Ship {ShipId=2,ShipName="La Pili",BuildingYear=1997,BuildingCost=2400, LastRepairDate=Convert.ToDateTime("12/10/1999")},
                new Ship {ShipId=3,ShipName="El Torreon",BuildingYear=1993,BuildingCost=1700, LastRepairDate=Convert.ToDateTime("12/07/2005")},
                new Ship {ShipId=4,ShipName="La Niña",BuildingYear=1998,BuildingCost=3100, LastRepairDate=Convert.ToDateTime("10/06/2002")}
            };
            fleet[0].crew = new List<Crewman>{ new Crewman{TripulanteId=1,NombreTripulante="David",Cargo="Contramaestre",FechaTituloNavegacion=Convert.ToDateTime("05/08/1999"), Barco = fleet[0]},
                                 new Crewman {TripulanteId=4,NombreTripulante="Elena",Cargo="Marinero",FechaTituloNavegacion=Convert.ToDateTime("16/08/1999"), Barco = fleet[0]},
                                 new Crewman {TripulanteId=5,NombreTripulante="Susana",Cargo="Sobrecargo",FechaTituloNavegacion=Convert.ToDateTime("17/10/2002"), Barco = fleet[0]}};

            fleet[1].crew = new List<Crewman> { new Crewman { TripulanteId = 2, NombreTripulante = "Felix", Cargo = "Almirante", FechaTituloNavegacion = Convert.ToDateTime("05/09/2001"), Barco = fleet[1] } };

            fleet[2].crew = new List<Crewman> { new Crewman { TripulanteId = 3, NombreTripulante = "Ricargo", Cargo = "Marinero", FechaTituloNavegacion = Convert.ToDateTime("16/08/1999"), Barco = fleet[2] } };

            fleet[3].crew = new List<Crewman>{ new Crewman{TripulanteId=6,NombreTripulante="Javier",Cargo="Marinero 1ª",FechaTituloNavegacion=Convert.ToDateTime("05/08/2001"), Barco = fleet[3]},
                                 new crew {TripulanteId=7,NombreTripulante="Federico",Cargo="Marinero 2ª",FechaTituloNavegacion=Convert.ToDateTime("19/01/1999"), Barco = fleet[3]},
                                 new crew {TripulanteId=8,NombreTripulante="Inmaculada",Cargo="Piloto",FechaTituloNavegacion=Convert.ToDateTime("17/10/2003"), Barco = fleet[3]}};


            return fleet;
        }
    }
}