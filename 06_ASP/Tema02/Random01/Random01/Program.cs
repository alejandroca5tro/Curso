using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random01
{
    class Program
    {
        static void Main(string[] args)
        {
            byte oportunities = 0;
            Random generator = new Random();
            int randomNumber = generator.Next(1, 100);

            int number;
            while (oportunities < 6)
            {
                Console.Write("Número: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("Acertaste");
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("Demasiado Alto");
                }
                else
                {
                    Console.WriteLine("Demasiado Bajo");
                }
                oportunities++;
            }
            Console.WriteLine("El número aleatorio era {0}", randomNumber);
        }
    }
}
