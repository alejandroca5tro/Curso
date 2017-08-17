using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_anidadas
{
    class Program
    {
        struct birthDate
        {
            public int day;
            public int month;
            public int year;
        }
        struct personType
        {
            public string name;
            public char initial;
            public birthDate birthDay;
            public float calification;
        }
        static void Main(string[] args)
        {
            personType person;
            person.birthDay.day;
        }
    }
}
