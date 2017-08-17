using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builtChain = new StringBuilder();
            builtChain.Append("Cadena primera ");
            builtChain.Append("Cadena segunda ");
            builtChain.Append("Cadena tercera ");

            Console.WriteLine(builtChain);
            Console.ReadLine();
        }
    }
}
