using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Combos.Models
{
    public class ComboComunidadesViewModel
    {
        public IEnumerable<Comunidad> Comunidades { get; set; }
        public int ComunidadSelec { get; set; }
    }
}