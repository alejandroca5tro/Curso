using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2_1
{
    class Program
    {
        public static float cubic(float n)
        {
            //return n * n * n;
            return (float)Math.Pow(n, 3);
        }
        static void Main(string[] args)
        {
            float n1 = 3.2f;
            float n2 = 5f;
            Console.WriteLine("Los cubos de {0} y {1} son {2} y {3}", n1, n2, cubic(n1), cubic(n2));
            Console.ReadLine();
        }
    }
}
