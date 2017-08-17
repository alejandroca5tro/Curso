using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_3
{
    public class ItalianPerson : Person
    {
        public new void greet()
        {
            Console.WriteLine("Ciao il mio nome è {0}", Name);
            Console.WriteLine("e ho {0} anni", Age);
        }
    }
}
