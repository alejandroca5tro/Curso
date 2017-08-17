using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercise07_1.Models
{
    public class Ship
    {
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public int BuildingCost { get; set; }
        public int BuildingYear { get; set; }
        public DateTime LastRepairDate { get; set; }

        public virtual ICollection<Crewman> crew { get; set; }
    }
}