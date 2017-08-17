using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examples02.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index(string id)
        {
            //string otraVaraible = id;
            ViewBag.Controller = "Admin";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult Alter(string id)
        {
            string otraVariable = id;
            return View("ActionName");
        }

        public RedirectToRouteResult MyRedireccionado()
        {
            return RedirectToAction("Index");
        }

        public RedirectResult MyRedireccionado2()
        {
            return RedirectToAction("Index");
        }
    }
}