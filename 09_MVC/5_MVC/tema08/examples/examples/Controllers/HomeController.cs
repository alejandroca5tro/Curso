using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id=1)
        {
            int identifier = id;
            return View();
        }

        public ActionResult Other()
        {
            return RedirectToAction("Index", new {id = 23});
        }

        public ActionResult More()
        {
            TempData["Message"] = "hola";
            TempData["Fecha"] = DateTime.Now;
            return Redirect("Index");
        }
    }
}