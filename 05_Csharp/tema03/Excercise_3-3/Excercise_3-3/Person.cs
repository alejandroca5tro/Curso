using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_3
{
    public class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public byte calculateAge(int birthYear)
        {
            return Convert.ToByte((2017 - birthYear));
        }
        public void greet()
        {
            Console.WriteLine("Hola soy {0}", Name);
            Console.WriteLine("y tengo {0} años", Age);
        }
    }
}
