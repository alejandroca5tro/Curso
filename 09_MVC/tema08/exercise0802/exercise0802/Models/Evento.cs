using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercise0802.Models
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public virtual Fotografo Fotografo { get; set; }
    }
}