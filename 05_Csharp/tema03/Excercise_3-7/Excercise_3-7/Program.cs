using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número 1: ");
            string n1 = Console.ReadLine();
            int num1 = int.Parse(n1);
            Console.Write("Número 1: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Número 1: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Statistics stat1 = new Statistics(num1, num2, num3);

            string totalAdd = stat1.add().ToString();
            string ave = Convert.ToDecimal(stat1.average()).ToString();
            Console.WriteLine("La suma es {0} y la media es {1}", totalAdd, ave);

            //Console.WriteLine("La suma es {0} y la media es {1}", stat1.add(), stat1.average().ToString("#.#"));
            Console.ReadLine();
        }
    }
}
