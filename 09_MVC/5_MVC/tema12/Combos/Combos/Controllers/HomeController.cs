using Combos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Combos.Controllers
{
    public class HomeController : Controller
    {
        private List<Ciudad> ciudades = new List<Ciudad>
        {
            new Ciudad{Id=1,Nombre="Caceres",CP="C23", ComunidadID=1},
            new Ciudad{Id=2,Nombre="Madrid",CP="M08", ComunidadID=2},
            new Ciudad{Id=3,Nombre="Barcelona",CP="B09", ComunidadID=3},
            new Ciudad{Id=1,Nombre="Tarragona",CP="T07", ComunidadID=2}
        };

        private List<Comunidad> comunidades = new List<Comunidad>
        {
            new Comunidad {Id=1,Nombre="Extremadura"},
            new Comunidad {Id=2,Nombre="Madrid"},
            new Comunidad {Id=1,Nombre="Cataluña"}
        };

        private void LlenarComboFormaUno()
        {
            //Rellenando una lista de SelectListItem
            var items = new List<SelectListItem>();

            items = ciudades.Select(c => new SelectListItem()
            {
                Text = c.Nombre,
                Value = c.Id.ToString()
            }).ToList();

            ViewBag.Cities = items;
        }

        private void LlenarComboFormaDos()
        {
            //clase SelectList que convierte por nosotros la lista de datos en una lista de SelectListItem
            var items = ciudades;
            var ciudad = new Ciudad();
            ciudad.Id=0;
            ciudad.Nombre ="- ELIJA CIUDAD -";
            ciudades.Add(ciudad);
            var elementos = items.OrderBy(i=>i.Id);
            ViewBag.Cities = new SelectList(elementos, "Id", "Nombre");
        }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            //A nivel de vista los dos trabajan de la misma forma
            //LlenarComboFormaUno();
            //return View();
            LlenarComboFormaDos();
            return View();
            //Dropdownlistfor
            //var items = ciudades;
            //var ciudad = new Ciudad();
            //ciudad.Id = 0;
            //ciudad.Nombre = "- ELIJA CIUDAD -";
            //ciudades.Add(ciudad);
            //ciudades = ciudades.OrderBy(c => c.Id).ToList();
            //var vm = new ComboCitiesViewModel();
            //vm.Cities = items;
            //return View(vm);
        }

        //PRIMERA FORMA
        //para LlenarComboFormaUno y LlenarComboFormaDos
        //[HttpPost]
        //public ActionResult Index(string Cities)
        //{
        //    var id = Int32.Parse(Cities);
        //    // Recuperamos la ciudad ==> Consulta a BBDD
        //    var city = ciudades.FirstOrDefault(c => c.Id == id).Nombre;
        //    // Operamos con la ciudad
        //    return View("Ciudad",(object)city);

        //    //Dos cosas a destacar:

        //    //Lo que recibimos en Cities NO es la lista de ciudades. Es el valor de la propiedad Value del SelectListItem seleccionado (en mi caso el ID de la ciudad seleccionada).
        //    //El nombre del parámetro (Cities) es el mismo que el nombre del campo del ViewBag (y el mismo que pusimos en la llamada a Html.DropDownList).
        //}

        //SEGUNDA FORMA : Los nombres son distintos
        //Ahora cuando recibimos los datos debemos tener presente que el parámetro ya 
        //NO se llama Cities, si no selectedCity:
        [HttpPost]
        public ActionResult Index(string selectedCity)
        {
            var id = Int32.Parse(selectedCity);
            // Recuperamos la ciudad ==> Consulta a BBDD
            var city = ciudades.FirstOrDefault(c => c.Id == id).Nombre;
            // Operamos con la ciudad
            return View("Ciudad", (object)city);
        }
        //Recibiendo los datos del Dropdownlistfor
        //[HttpPost]
        //public ActionResult Index(ComboCitiesViewModel info)
        //{
        //    var id = info.SelectedCity;
        //    // Recuperamos la ciudad ==> Consulta a BBDD
        //    var city = ciudades.FirstOrDefault(c => c.Id == id).Nombre;
        //    // Operamos con la ciudad
        //    return View("Ciudad",(object)city);
        //}

       
	}
}