using exercise02_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace exercise02_2.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public string Index()
        {
            return "Página de jugadores";
        }

        private List<Player> CreatePlayerList()
        {
            List<Player> playerList = new List<Player>
            {
                new Player { PlayerId = 1, NameLastName = "Sebastian Bach", Position = "Medio Centro", Salary = 540000 },
                new Player { PlayerId = 2, NameLastName = "Ludwig Van Beethoven", Position = "Delantero", Salary = 650000 },
                new Player { PlayerId = 3, NameLastName = "Amadeus Mozart", Position = "Defensa", Salary = 1000000 },
                new Player { PlayerId = 4, NameLastName = "Antonio Vivaldi", Position = "Lateral Izquierdo", Salary = 550000 }
            };
            return playerList;       
        }

        private List<Player> InsertPlayer()
        {
            List<Player> list = CreatePlayerList();

            Player newPlayer = new Player();
            newPlayer.PlayerId = 5;
            newPlayer.NameLastName = "Richard Wagner";
            newPlayer.Position = "Medio Centro";
            newPlayer.Salary = 800000;

            list.Add(newPlayer);
            return list;
        }

        public ActionResult ShowPlayers()
        {
            List<Player> list = CreatePlayerList();
            var query =
                list
                .Select(p => p)
                .OrderByDescending(p => p.NameLastName);
            StringBuilder result = new StringBuilder();
            foreach (var p in query)
            {
                result.AppendFormat("Id: {0}", p.PlayerId);
                result.AppendFormat("Nombre y Apellidos: {0}", p.NameLastName);
                result.AppendFormat("Posición: {0}", p.Position);
                result.AppendFormat("Sueldo: {0}", p.Salary);
            }
            return View("Result", (object)result.ToString());
        }

        public ActionResult ShowWhoEarnMost()
        {
            List<Player> list = CreatePlayerList();
            var whoEarnMost =
                list.Where(p => p.Salary.Equals(list.Select(pS => pS.Salary).Max()))
                .Select(p => p.NameLastName)
                .FirstOrDefault();
            return View("Result", (object)String.Format("El que más gana es: {0}", whoEarnMost.ToString()));
        }

        public ActionResult ShowTotalSalaries()
        {
            List<Player> list = CreatePlayerList();
            var total =
                list
                .Sum(p => p.Salary);
            return View("Result", (object)String.Format("El total de sueldos es: {0}", total.ToString()));
        }

        public ActionResult ShowWhoEarnLess()
        {
            List<Player> list = CreatePlayerList();
            var whoEarnLess =
                list
                .OrderBy(p => p.Salary)
                .Take(3)                
                .Select(p => new
                {
                    p.NameLastName,
                    p.Salary
                }).ToList();
            StringBuilder result = new StringBuilder();            
            foreach (var p in whoEarnLess)
            {
                result.AppendFormat("Nombre y Apellidos: {0}", p.NameLastName);
                result.AppendFormat("Sueldo: {0}", p.Salary);
            }
            return View("Result", (object)result.ToString());
        }

        public ActionResult ShowLessThanAverage()
        {
            List<Player> list = CreatePlayerList();
            var lessThanAverage =
                list
                .Where(p => p.Salary < list.Select(pS => pS.Salary).Average())
                .Select(p => new
                {
                    Jugador = p.NameLastName
                });
            StringBuilder result = new StringBuilder();
            foreach (var p in lessThanAverage)
            {
                result.AppendFormat("Nombre y Apellidos: {0}", p.Jugador);
            }
            return View("Result", (object)result.ToString());
        }
    }
}