using Combos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Combos.Controllers
{
    public class ComunidadController : Controller
    {
        private List<Comunidad> comunidades = new List<Comunidad>
        {
            new Comunidad {Id=1,Nombre="Extremadura"},
            new Comunidad {Id=2,Nombre="Madrid"},
            new Comunidad {Id=1,Nombre="Cataluña"}
        };
        //
        // GET: /Comunidad/
        public ActionResult Index()
        {
            var items = comunidades;
            var vm = new ComboComunidadesViewModel();
            vm.Comunidades = items;
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(ComboComunidadesViewModel info)
        {
            var id = info.ComunidadSelec;
            // Recuperamos la comunidad ==> Consulta a BBDD
            var comunidad = comunidades.FirstOrDefault(c => c.Id == id);
            // Operamos con la comunidad
            return View();
        }
	}
}