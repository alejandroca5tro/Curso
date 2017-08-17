using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Faculty
    {
        public int Code { get; set; }
        public string Name { get; set; }

        static public Faculty[] Facultys =
        {

            new Faculty
            {
                Code = 1,
                Name = "Facultad de Medicina"
            },

            new Faculty
            {
                Code = 2,
                Name = "Facultad de Fisicas"
            },

            new Faculty
            {
                Code = 3,
                Name = "Facultad de Matematicas"
            },
        };
    }           
}
