using examples03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examples03.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Country> countries = CreateCountries();
            FillDropDownList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(int Country)
        {

            return View();
        }

        private List<Country> CreateCountries()
        {
            List<Country> countries = new List<Country>
            {
                new Country {Id=1, Name="Francia" },
                new Country {Id=2, Name="España" },
                new Country {Id=3, Name="Italia" },
                new Country {Id=4, Name="Bulgaria" }
            };

            var ordered =
                countries
                .Select(c => c)
                .OrderBy(c => c.Name)
                .ToList();

            return ordered;                
        }

        private void FillDropDownList(int Id=0)
        {
            List<SelectListItem> Countries = new List<SelectListItem>();
            Countries.Add(new SelectListItem()
            {
                Value = "0",
                Text = "Elige un país",
                Selected = true
            });

            List<Country> countries = CreateCountries();
            foreach (Country c in countries)
            {
                Countries.Add(new SelectListItem()
                {
                    Value = c.Id.ToString(),
                    Text = c.Name,
                    Selected = Id == c.Id ? true : false
                });
            }

            ViewData["Countries"] = Countries;
        }
    }
}