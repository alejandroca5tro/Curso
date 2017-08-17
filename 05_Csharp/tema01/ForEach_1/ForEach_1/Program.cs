using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Alberto", "Juan", "Sergio"};

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
