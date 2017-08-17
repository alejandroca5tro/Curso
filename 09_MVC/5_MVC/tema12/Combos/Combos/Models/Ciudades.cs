using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Combos.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CP { get; set; }
        public int ComunidadID { get; set; }
    }

    public class Comunidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}