using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];            
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduce número en la posición {0}: ", i + 1);
                numbers[1] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
