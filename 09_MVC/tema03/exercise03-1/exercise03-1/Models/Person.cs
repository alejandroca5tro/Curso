using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exercis03_2.Models
{
    public class Person
    {
        [Required]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Profession { get; set; }
        public int? Salary { get; set; }

    }
}