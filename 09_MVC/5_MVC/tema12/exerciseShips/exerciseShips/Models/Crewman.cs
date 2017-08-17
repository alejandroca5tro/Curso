using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exerciseShips.Models
{
    public class Crewman
    {
        public int TripulanteId { get; set; }
        public string NombreTripulante { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaTituloNavegacion { get; set; }
        public int BarcoId { get; set; }

        public virtual Ship Ship { get; set; }
    }
}