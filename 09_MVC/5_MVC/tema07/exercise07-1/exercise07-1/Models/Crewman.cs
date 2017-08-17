using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercise07_1.Models
{
    public class Crewman
    {
        public int CrewmanId { get; set; }
        public string SailorName { get; set; }
        public string Grade { get; set; }
        public DateTime NavigationTitleDate { get; set; }
        public int ShipId { get; set; }

    }
}