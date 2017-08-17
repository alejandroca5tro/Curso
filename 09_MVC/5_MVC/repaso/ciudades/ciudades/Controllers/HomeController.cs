using ciudades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciudades.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var communities = Community.GenerateCommunities();
            var vm = new VMIndex();
            vm.communities = communities;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(VMIndex info)
        {
            var id = info.SelectedCommunity;
            var cities = City.GenerateCities();

            var query =
                cities
                .Where(ci => ci.CommunityId.Equals(id))
                .Select(ci => ci)
                .ToList();

            var vm = new VMIndex();
            vm.cities = query;
            return View(query);
        }
    }
}