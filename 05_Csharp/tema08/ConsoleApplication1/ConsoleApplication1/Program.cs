using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            DateTime birthDate = new DateTime(1990, 9, 18);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");

            Console.WriteLine(birthDate.ToShortDateString());

            TimeSpan difference = currentDate.Subtract(birthDate);

            Console.WriteLine(difference.Days);

            Console.WriteLine(difference)

            Console.ReadKey();
        }
    }
}
