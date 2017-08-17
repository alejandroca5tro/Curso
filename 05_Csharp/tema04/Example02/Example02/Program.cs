using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates point1 = new Coordinates();
            Coordinates point2 = new Coordinates(5,3);

            Console.WriteLine("Coordenadas 1 son {0}", point1);
            Console.WriteLine("Coordenadas 2 son {0}", point2);
            Console.ReadKey();

        }
    }
}
