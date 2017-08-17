using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce nombre: ");
            string name = Console.ReadLine();
            Employee employee1 = new Employee();
            employee1.print(name);
            Console.ReadLine();
        }
    }
}
