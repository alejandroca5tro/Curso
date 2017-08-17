using exercis03_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace exercise03_1.Controllers
{
    public class HomeController : Controller
    {
        private List<Person> CreatePerson()
        {
            List<Person> person01 = new List<Person>
            {
                new Person
                {
                    PersonId = 1,
                    Name = "John",
                    Age = 50,
                    Profession = "Fisherman",
                    Salary = 2050
                },
            };
            return person01;
        }

        public ActionResult ShowPerson()            
        {
            List<Person> person = CreatePerson();
            var query =
                person
                .Select(p => p);
            StringBuilder result = new StringBuilder();
            foreach (var p in query)
            {
                result.AppendLine("Id:" + p.PersonId);
                result.AppendLine("Id:" + p.Name);
                result.AppendLine("Id:" + p.Age);
                result.AppendLine("Id:" + p.Profession);
                result.AppendLine("Id:" + p.Salary);
            }
            return View("Result", (object)result.ToString());
        }            
    }
}