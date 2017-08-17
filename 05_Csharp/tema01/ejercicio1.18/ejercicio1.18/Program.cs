using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._18
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Edad: ");
                int Edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine("Ha habido un error en la edad {0}", error.Message);
            }
            Console.WriteLine("Año de anicimiento: ");
            int year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
