using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repaso01.Models
{
    public class Popurri
    {
        public List<Coche> listaCoches { get; set; }

        public int valor { get; set; }
        public string descripcion { get; set; }            
        
        listacoches = Coche.obtenerTodosCoches();   
    }
}