using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que genere dos números aleatorios
            Random randomNumber = new Random();

            //el primero entre 10 y 20 
            int rN1 = randomNumber.Next(10, 20);

            //y el segundo entre 1 y 10
            int rN2 = randomNumber.Next(1, 10);

            int appOption=0;

            int mathOption;

            Console.WriteLine("Se han generado dos númeos aleatorios");

            //luego mediante un Menú
            while (appOption!=3)
            {
                Console.WriteLine("Elige una opción: ");
                Console.WriteLine();
                Console.WriteLine("1 - Ver los números generados");
                Console.WriteLine("2 - Realizar una operación matemática básica");
                Console.WriteLine("3 - Salir");
                Console.WriteLine();

                appOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (appOption)
                {

                    //El menú dispondrá también de la opción de mostrar los números generados
                    case 1:
                        Console.WriteLine("Número 1: {0}", rN1.ToString());
                        Console.WriteLine("Número 2: {0}", rN2.ToString());
                        Console.WriteLine();
                        break;
                        //el usuario elegirá entre una de las cuatro operaciones básicas(Sumar, Restar, Multiplicar o Dividir) sobre los números generados.
                    case 2:
                        Console.WriteLine("Elige una operación:");
                        Console.WriteLine();
                        Console.WriteLine("1 - Suma");
                        Console.WriteLine("2 - Resta");
                        Console.WriteLine("3 - Multiplicación");
                        Console.WriteLine("4 - División");
                        Console.WriteLine();
                        mathOption = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (mathOption)
                        {
                            case 1:
                                int add = rN1 + rN2;
                                Console.WriteLine("{0} + {1} = {2}", rN1.ToString(), rN2.ToString(), add.ToString());
                                break;
                            case 2:
                                int sub = rN1 - rN2;
                                Console.WriteLine("{0} - {1} = {2}", rN1.ToString(), rN2.ToString(), sub.ToString());
                                break;
                            case 3:
                                int pro = rN1 * rN2;
                                Console.WriteLine("{0} x {1} = {2}", rN1.ToString(), rN2.ToString(), pro.ToString());
                                break;
                            case 4:
                                double div = Convert.ToDouble(rN1) / Convert.ToDouble(rN2);
                                Console.WriteLine("{0} / {1} = {2}", rN1.ToString(), rN2.ToString(), div.ToString("#.##"));
                                break;
                            default:
                                Console.WriteLine("No ha elegido un número válido");                                
                                break;
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("No ha elegido un número válido");
                        Console.WriteLine();
                        break;
                }
            }
            //y de salir del sistema. 
        }
    }
}
