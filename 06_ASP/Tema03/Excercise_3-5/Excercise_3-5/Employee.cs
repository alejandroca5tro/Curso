using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_5
{
    public class Employee
    {
        public string Name { get; set; }
        const int salary = 1500;

        public void print(string nam)
        {
            this.Name = nam;
            Console.WriteLine("El sueldo de {0} es de {1}", Name, salary);
        }
    }
}
