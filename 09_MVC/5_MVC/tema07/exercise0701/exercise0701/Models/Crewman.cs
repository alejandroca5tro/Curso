using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercise0701.Models
{
    public class Crewman
    {
        public int CrewmanId { get; set; }
        public string CrewmanName { get; set; }
        public string Position { get; set; }
        public DateTime NavigationTitleDate { get; set; }
        public int ShipId { get; set; }

    }
}