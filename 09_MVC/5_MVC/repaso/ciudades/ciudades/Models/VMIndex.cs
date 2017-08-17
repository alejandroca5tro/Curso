using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciudades.Models
{
    public class VMIndex
    {
        public IEnumerable<City> cities { get; set; }
        public int SelectedCity { get; set; }
        public IEnumerable<Community> communities { get; set; }
        public int SelectedCommunity { get; set; }
    }
}