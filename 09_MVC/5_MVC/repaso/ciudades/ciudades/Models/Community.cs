using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciudades.Models
{
    public class Community
    {
        public int? Id { get; set; }
        public string Name { get; set; }


        public static Community[] GenerateCommunities()
        {
            Community[] communities =
            {
                new Community {Id = null, Name = "Escoge una comunidad" },
                new Community {Id =1, Name = "Andalucía" },
                new Community {Id =2, Name = "Aragón" },
                new Community {Id =3, Name = "Canarias" },
                new Community {Id =4, Name = "Cantabria" },
                new Community {Id =5, Name = "Castilla y León" },
                new Community {Id =6, Name = "Castilla-La Mancha" },
                new Community {Id =7, Name = "Cataluña" },
                new Community {Id =8, Name = "Comunidad de Madrid" },
                new Community {Id =9, Name = "Comunidad Foral de Navarra" },
                new Community {Id =10, Name = "Comunidad Valenciana" },
                new Community {Id =11, Name = "Extremadura" },
                new Community {Id =12, Name = "Galicia" },
                new Community {Id =13, Name = "Islas Baleares" },
                new Community {Id =14, Name = "Islas Canarias" },
                new Community {Id =15, Name = "La Rioja" },
                new Community {Id =16, Name = "País Vasco" },
                new Community {Id =17, Name = "Principado de Asturias" },
                new Community {Id =18, Name = "Región de Murcia" },
            };
            return communities;
        }
    } 
}

