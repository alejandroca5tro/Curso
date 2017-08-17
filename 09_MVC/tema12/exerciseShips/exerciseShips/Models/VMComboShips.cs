using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exerciseShips.Models
{
    public class VMComboShips
    {
        public IEnumerable<Ship> Ships { get; set; }

        public int SelectedShip { get; set; }
    }
}