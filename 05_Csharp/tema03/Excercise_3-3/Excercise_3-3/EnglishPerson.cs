using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_3
{
    public class EnglishPerson : Person
    {
        public void drinkTea()
        {
            Console.WriteLine("I'm having tea");
        }
        public new void greet()
        {
            Console.WriteLine("Hi I am {0}", Name);
            Console.WriteLine("and I am {0}", Age);
        }
    }
}
