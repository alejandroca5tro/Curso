using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciudades.Models
{
    public class City
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? CommunityId { get; set; }

        public static City[] GenerateCities()
        {
            City[] cities =
            {
                new City {Id = null, Name = "Escoge una ciudad", CommunityId = null },
                new City {Id =4, Name = "Almería", CommunityId = 1 },
                new City {Id =14, Name = "Cádiz", CommunityId = 1 },
                new City {Id =18, Name = "Córdoba", CommunityId = 1 },
                new City {Id =22, Name = "Granada", CommunityId = 1 },
                new City {Id =24, Name = "Huelva", CommunityId = 1 },
                new City {Id =26, Name = "Jaén", CommunityId = 1 },
                new City {Id =34, Name = "Málaga", CommunityId = 1 },
                new City {Id =44, Name = "Sevilla", CommunityId = 1 },
                new City {Id =25, Name = "Huesca", CommunityId = 2 },
                new City {Id =47, Name = "Teruel", CommunityId = 2 },
                new City {Id =52, Name = "Zaragoza", CommunityId = 2 },
                new City {Id =28, Name = "Las Palmas", CommunityId = 3 },
                new City {Id =41, Name = "Santa Cruz de Tenerife", CommunityId = 3 },
                new City {Id =15, Name = "Cantabria", CommunityId = 4 },
                new City {Id =7, Name = "Ávila", CommunityId = 5 },
                new City {Id =12, Name = "Burgos", CommunityId = 5 },
                new City {Id =30, Name = "León", CommunityId = 5 },
                new City {Id =38, Name = "Palencia", CommunityId = 5 },
                new City {Id =40, Name = "Salamanca", CommunityId = 5 },
                new City {Id =43, Name = "Segovia", CommunityId = 5 },
                new City {Id =45, Name = "Soria", CommunityId = 5 },
                new City {Id =50, Name = "Valladolid", CommunityId = 5 },
                new City {Id =51, Name = "Zamora", CommunityId = 5 },
                new City {Id =2, Name = "Albacete", CommunityId = 6 },
                new City {Id =17, Name = "Ciudad Real", CommunityId = 6 },
                new City {Id =19, Name = "Cuenca", CommunityId = 6 },
                new City {Id =23, Name = "Guadalajara", CommunityId = 6 },
                new City {Id =48, Name = "Toledo", CommunityId = 6 },
                new City {Id =10, Name = "Barcelona", CommunityId = 7 },
                new City {Id =21, Name = "Girona", CommunityId = 7 },
                new City {Id =31, Name = "Lleida", CommunityId = 7 },
                new City {Id =46, Name = "Tarragona", CommunityId = 7 },
                new City {Id =33, Name = "Madrid", CommunityId = 8 },
                new City {Id =36, Name = "Navarra", CommunityId = 9 },
                new City {Id =3, Name = "Alicante", CommunityId = 10 },
                new City {Id =16, Name = "Castellón", CommunityId = 10 },
                new City {Id =49, Name = "València", CommunityId = 10 },
                new City {Id =8, Name = "Badajoz", CommunityId = 11 },
                new City {Id =13, Name = "Cáceres", CommunityId = 11 },
                new City {Id =1, Name = "A Coruña", CommunityId = 12 },
                new City {Id =32, Name = "Lugo", CommunityId = 12 },
                new City {Id =37, Name = "Ourense", CommunityId = 12 },
                new City {Id =39, Name = "Pontevedra", CommunityId = 12 },
                new City {Id =9, Name = "Baleares", CommunityId = 13 },
                new City {Id =29, Name = "Las Palmas", CommunityId = 14 },
                new City {Id =42, Name = "Santa Cruz de Tenerife", CommunityId = 14 },
                new City {Id =27, Name = "La Rioja", CommunityId = 15 },
                new City {Id =5, Name = "Araba", CommunityId = 16 },
                new City {Id =11, Name = "Bizkaia", CommunityId = 16 },
                new City {Id =20, Name = "Gipuzkoa", CommunityId = 16 },
                new City {Id =6, Name = "Asturias", CommunityId = 17 },
                new City {Id =35, Name = "Murcia", CommunityId = 18 }            
            };
            return cities;
        }
    }
}