using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras01
{
    class Program
    {
        struct personType
        {
            public string name;
            public char initial;
            public int age;
            public float calification;
        }

        static void Main(string[] args)
        {
            personType person;

            person.name = "Javier";
            person.initial = 'J';
            person.age = 23;
            person.calification = 2.3f;

            Console.WriteLine("La edad de {0} es {1}", person.name, person.age);
            Console.ReadLine();
        }
    }
}
