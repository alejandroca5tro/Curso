using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_2
{
    public class TestPerson2
    {
        static void Main(string[] args)
        {
            Person person3 = new Person();
            person3.Name = "Pepe";
            person3.Age = person3.calculateAge(1965);
            person3.greet();

            Person person4 = new Person();
            person4.Name = "Luis";
            person4.Age = person4.calculateAge(1975);
            person4.greet();

            EnglishPerson person5 = new EnglishPerson();
            person5.Name = "John";
            person5.Age = person5.calculateAge(1985);
            person5.greet();
            person5.drinkTea();

            Console.ReadLine();
        }
    }
}
