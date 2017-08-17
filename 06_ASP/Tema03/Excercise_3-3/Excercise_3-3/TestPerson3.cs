using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_3
{
    public class TestPerson3
    {
        static void Main(string[] args)
        {
            Person person6 = new Person();
            person6.Name = "Jose";
            person6.Age = person6.calculateAge(1965);
            person6.greet();

            EnglishPerson person7 = new EnglishPerson();
            person7.Name = "Bryan";
            person7.Age = person7.calculateAge(1975);
            person7.greet();
            person7.drinkTea();

            EnglishPerson person8 = new EnglishPerson();
            person8.Name = "Charles";
            person8.Age = person8.calculateAge(1985);
            person8.greet();
            person8.drinkTea();

            ItalianPerson person9 = new ItalianPerson();
            person9.Name = "Andreas";
            person9.Age = person9.calculateAge(1995);
            person9.greet();

            Console.ReadLine();
        }
    }
}
