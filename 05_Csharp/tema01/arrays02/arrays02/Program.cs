using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            int add = 0;
            for (int i = 0; i < 4; i++)
            {
                add += numbers[i];
            }
            Console.ReadLine();
        }
    }
}
