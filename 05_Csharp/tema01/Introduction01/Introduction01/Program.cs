using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction01
{
    class Program
    {
        public static void saludar()
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadLine();
        }
        public static void writeNumbers(float n, int m)
        {
            Console.WriteLine(n.ToString("#.#"));
            Console.WriteLine(m.ToString());
            Console.ReadLine();
        }
        public static double square(int n)
        {
            //return n * n;
            return Math.Pow(n, 2);
        }

        public static float calculateHighest(float n1, float n2)
        {
            if (n1 < n2) return n1;
            else return n2;
        }
        static void Main(string[] args)
        {
            //saludar();
            //writeNumbers(2.3f, 1232131);
            //double totalSquare = square(2);
            //Console.WriteLine(totalSquare.ToString());
            //Console.ReadLine();
            float highestNumber = calculateHighest(2.3f, 5.2f);
            Console.ReadLine();
        }
    }
}