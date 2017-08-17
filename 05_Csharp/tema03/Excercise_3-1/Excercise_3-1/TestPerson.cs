using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_1
{
    public class TestPerson
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Juan";
            person1.Age = person1.calculateAge(1965);
            person1.greet();

            Person person2 = new Person();
            person2.Name = "Inés";
            person2.Age = person1.calculateAge(1995);
            person2.greet();

            Console.ReadLine();
        }
    }
}
