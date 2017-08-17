using examples04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examples04.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //FillComboWay1();



            var items = cities;
            var vm = new VMComboCities();
            vm.Cities = items;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(VMComboCities info)
        {
            var id = info.SelectedCity;

            var city = cities.FirstOrDefault(c => c.Id == id);
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(string selectedCity)
        //{
        //    var id = Int32.Parse(selectedCity);

        //    var city = cities.FirstOrDefault(c => c.Id == id);
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Index(string Cities)
        //{
        //    var id = Int32.Parse(Cities);

        //    var city = cities.FirstOrDefault(c => c.Id == id);
        //    return View();
        //}

        private List<City> cities = new List<City>
        {
            new City {Id = 1, Name = "Cáceres", PostalCode = "C23", CommunityId = 1},
            new City {Id = 2, Name = "Madrid", PostalCode = "M08", CommunityId = 2},
            new City {Id = 3, Name = "Barcelona", PostalCode = "B09", CommunityId = 3},
            new City {Id = 4, Name = "Tarragona", PostalCode = "T07", CommunityId = 3}
        };

        private void FillComboWay1()
        {
            var items = new List<SelectListItem>();
            items =
                cities.
                Select(c => new SelectListItem()
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                }).ToList();

            ViewBag.Cities = items;
        }

        private void FillComboWay2()
        {
            var items = cities;
            ViewBag.Cities = new SelectList(items, "Id", "Name");
        }
    }
}