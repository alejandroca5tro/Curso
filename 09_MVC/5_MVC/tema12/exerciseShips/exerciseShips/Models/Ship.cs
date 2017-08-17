using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exerciseShips.Models
{
    public class Ship
    {
        public int BarcoId { get; set; }
        public string NombreBarco { get; set; }
        public int CosteConstruccion { get; set; }
        public int AñoConstruccion { get; set; }
        public DateTime FechaUltimaReparacion { get; set; }

        public virtual ICollection<Crewman> crew { get; set; }
    }
}