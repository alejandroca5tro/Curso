using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002EjemploConversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber, secondNumber, add;
            Console.Write("Introduce el número 1:");
            firstNumber = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduce el número 2:");
            secondNumber = Convert.ToSingle(Console.ReadLine());

            add = firstNumber + secondNumber;


            Console.WriteLine("La suma es {0}", add.ToString("0.000"));
            Console.ReadLine();
        }
    }
}
