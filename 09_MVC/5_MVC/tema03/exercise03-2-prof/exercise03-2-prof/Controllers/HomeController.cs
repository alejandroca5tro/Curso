using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exercise03_2_prof.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        private List<Alumno> CrearListaAlumnos()
        {
            List<Alumno> lista = new List<Alumno>
            {
                new Alumno { AlumnoId = 1, Nombre = "Alumno1", Edad = 23, Trabaja = true, Nota = 6 },
                new Alumno { AlumnoId = 2, Nombre = "Alumno2", Edad = 25, Trabaja = true, Nota = 7 },
                new Alumno { AlumnoId = 3, Nombre = "Alumno3", Edad = 20, Trabaja = true, Nota = 5 }
            };

            return lista;
        }

        public ActionResult MostrarAlumnos()
        {
            List<Alumno> lista = CrearListaAlumnos();
            var query = lista
                .Select(a => a)
                .OrderByDescending(a => a.Nombre)
                .ToList();

            return View(query);
        }



    }
}