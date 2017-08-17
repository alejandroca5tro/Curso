using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examples02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomerVariable()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomerVariable";
            ViewBag.CustomerVariable = RouteData.Values["id"];
            return View();
        }
    }
}