using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercise0802.Models
{
    public class Fotografo
    {
        public int IdFotografo { get; set; }
        public string NombreApell { get; set; }
        public string Direccion { get; set; }
        public int IdEvento { get; set; }
        
        public virtual ICollection<Evento> eventos { get; set; }
    }
}