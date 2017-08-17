using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examples04.Models
{
    public class VMComboCities
    {
        public IEnumerable<City> Cities { get; set; }

        public int SelectedCity { get; set; }
    }
}