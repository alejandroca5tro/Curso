using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repaso01.Models
{
    public class Coche
    {
        public int CocheId { get; set; }
        public string Descripcion { get; set; }

        public static obtenerTodosCoches()
        {
            var query = datos.Coche
                .select(c => c.nombre).tolist();

            return query;
        }

    }
}