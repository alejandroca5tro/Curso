using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara dos objetos: Rueda y Moneda
            Circunferencia rueda = new Circunferencia();

            Circunferencia moneda = new Circunferencia();

            //y realiza las siguientes operaciones
            //a) Inicializa el radio de la Rueda con el valor de 10.2
            rueda.modifyRadius(10.2);

            //b) Inicializa el radio de la Moneda con el valor de 1.4
            moneda.modifyRadius(1.4);

            //c) Imprime el área de la Rueda.
            string wheelArea = rueda.calculateArea().ToString("#.##");
            Console.WriteLine("El área de la rueda es igual a {0}", wheelArea);
            Console.ReadKey();

            //d) Imprime el área de la Moneda.
            string coinArea = moneda.calculateArea().ToString("#.##");
            Console.WriteLine("El área de la moneda es igual a {0}", coinArea);
            Console.ReadKey();

            //e) Imprime el perímetro de la Rueda.
            string wheelPerimeter = rueda.calculatePerimeter().ToString("#.##");
            Console.WriteLine("El perímetro de la rueda es igual a {0}", wheelPerimeter);
            Console.ReadKey();

            //f) Imprime el perímetro de la Moneda.
            string coinPerimeter = moneda.calculatePerimeter().ToString("#.##");
            Console.WriteLine("El perímetro de la rueda es igual a {0}", coinPerimeter);
            Console.ReadKey();
        }
    }
}
