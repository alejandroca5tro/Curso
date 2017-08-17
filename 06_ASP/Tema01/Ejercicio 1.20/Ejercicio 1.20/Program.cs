using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 10;     

            string[] names = new string[capacity];            

            Console.WriteLine("1. Añadir nombre");
            Console.WriteLine("2. Insertar nombre");
            Console.WriteLine("3. Borrar nombre");
            Console.WriteLine("4. Mostrar los nombres");
            Console.WriteLine("5. Salir");

            int nameQuantity = 0;
            int option = 0;
            while (option != 5)
            {
                Console.Write("Elige una opción: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Escribe el nombre: ");
                        string name = Console.ReadLine();
                        names[nameQuantity] = name;
                        nameQuantity++;
                        break;
                    case 2:
                        Console.Write("Escribe el nombre: ");
                        name = Console.ReadLine();
                        Console.Write("Define la posición: ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        if (nameQuantity < capacity)
                        {
                            Console.WriteLine("Insertando {0} en la posición {1}", name, position);
                            for (int i = nameQuantity; i > position - 1; i--)
                            {
                                names[i] = names[i - 1];
                            }
                            names[position - 1] = name;
                            nameQuantity++;
                        }
                        break;
                    case 3:
                        Console.Write("Introduce la posición a borrar: ");
                        int positionToErase = Convert.ToInt32(Console.ReadLine());
                        for (int i = positionToErase - 1; i < capacity; i++)
                        {
                            names[i] = names[i + 1];
                        }
                        nameQuantity--;
                        break;
                    case 4:
                        Console.WriteLine("Los nombres almacenados son los siguientes:");
                        for (int i = 0; i < nameQuantity; i++)
                        {
                            Console.WriteLine("{0}", names[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("No hay ninguna opción definida para ese valor");
                        break;
                }
            }
        }
    }
}
