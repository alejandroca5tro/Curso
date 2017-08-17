using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            double height = 3.0;

            Circle cir1 = new Circle(radius);
            Cylinder cy1 = new Cylinder(radius, height);

            Console.WriteLine("Area del círculo es: {0:F2}", cir1.Area());
            Console.WriteLine("Area del cilindro es: {0:F2}", cy1.Area());
            Console.ReadKey();
        }
    }
}
