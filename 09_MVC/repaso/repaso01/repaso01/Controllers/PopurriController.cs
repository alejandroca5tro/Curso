using repaso01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace repaso01.Controllers
{
    public class PopurriController : Controller
    {
        // GET: Popurri
        public ActionResult Index()
        {
            Popurri popu = new Popurri();

            return View(popu);
        }
    }
}