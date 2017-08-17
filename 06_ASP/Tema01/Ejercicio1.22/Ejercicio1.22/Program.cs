using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe varios números separados por espacios");
            string numbers = Console.ReadLine();
            string[] numbersForAdd = numbers.Split(' ');
            int add=0;
            for (int i = 0; i < numbersForAdd.Length; i++)
            {
                add += Convert.ToInt32(numbersForAdd[i]);
            }
            Console.WriteLine("La suma de todos los números es {0}", add);
            Console.ReadLine();
        }
    }
}
