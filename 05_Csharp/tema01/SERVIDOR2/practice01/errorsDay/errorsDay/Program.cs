using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorsDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, re;
            try
            {
                Console.WriteLine("Primer número: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Segundo número: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                re = n1 / n2;
                Console.WriteLine("Resultado es: {0}", re);
            }
            catch (FormatException)
            {
                Console.WriteLine("No es un formato correcto.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Intento de dividir por cero.");
            }
            Console.ReadLine();
            
        }
    }
}
