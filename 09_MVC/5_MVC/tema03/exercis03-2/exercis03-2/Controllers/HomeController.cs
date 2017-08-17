using exercis03_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exercis03_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CreateStudents()
        {
            Student[] students = 
            {
                new Student
                {
                    StudentId = 1,
                    Name = "John",
                    Age = 20,
                    Works = true,
                    Grade = Convert.ToDecimal(8.5)
                },
                 new Student
                {
                    StudentId = 2,
                    Name = "Pepe",
                    Age = 22,
                    Works = false,
                    Grade = Convert.ToDecimal(7.5)
                },
                  new Student
                {
                    StudentId = 3,
                    Name = "Jose",
                    Age = 24,
                    Works = true,
                    Grade = Convert.ToDecimal(6.5)
                },
                   new Student
                {
                    StudentId = 4,
                    Name = "Carlos",
                    Age = 26,
                    Works = false,
                    Grade = Convert.ToDecimal(9.5)
                },
            };
            return View(students);
        }

        public ActionResult ShowWorkingStudents()
        {
            var students = CreateStudents();
        }
    }
}