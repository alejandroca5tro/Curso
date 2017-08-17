using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: ");
            string n = Console.ReadLine();

            Console.Write("Apellido: ");
            string f = Console.ReadLine();

            Concatenate concatenated1 = new Concatenate(n, f);
            string conName = concatenated1.toConcatenate();

            Console.WriteLine("El nombre completo es {0}", conName);
            Console.ReadLine();
        }
    }
}
