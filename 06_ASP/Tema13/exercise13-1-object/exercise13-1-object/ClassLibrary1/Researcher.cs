using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Researcher
    {
        public string DNI { get; set; }
        public string FirstLastName { get; set; }
        public int Faculty { get; set; }

        static public Researcher[] Researchers =
        {
            new Researcher
            {
                DNI = "789123A",
                FirstLastName = "Andrés González",
                Faculty = 1,
            },

            new Researcher
            {
                DNI = "123456A",
                FirstLastName = "Elena Alvarez",
                Faculty = 2,
            },

            new Researcher
            {
                DNI = "456789B",
                FirstLastName = "Inés Desigual",
                Faculty = 2,
            },

            new Researcher
            {
                DNI = "987654C",
                FirstLastName = "Antonio Sánchez",
                Faculty = 1,
            },
        };
    }
}
