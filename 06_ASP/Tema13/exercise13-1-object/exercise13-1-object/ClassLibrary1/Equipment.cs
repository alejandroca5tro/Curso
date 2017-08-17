using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Equipment
    {
        public string serialNum { get; set; }
        public string Name { get; set; }
        public int Faculty { get; set; }

        static public Equipment[] Equipments =
        {
            new Equipment
            {
               serialNum="A233",
               Name="Magnetoscopio Bascular",
               Faculty = 1
            },

            new Equipment
            {
                serialNum = "B786",
                Name = "Condensador de Partículas",
                Faculty = 1
            },

            new Equipment
            {
                serialNum = "C765",
                Name = "Super Ordenador",
                Faculty = 2
            },

            new Equipment
            {
                serialNum = "D432",
                Name = "Ionizador Atómico",
                Faculty = 3
            },
        };
    }
}
