using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_25
{
    class Program
    {
        struct file
        {
            public string name;
            public uint size;          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("- SISTEMA DE ARCHIVOS V.1.0 -");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            ushort capacity = 1000;
            file[] files = new file[capacity];
            ushort fileNumber = 0;

            Console.WriteLine("1. Nuevo fichero");
            Console.WriteLine("2. Mostrar todos");
            Console.WriteLine("3. Filtrar");
            Console.WriteLine("4. Ver fichero");
            Console.WriteLine("5. Salir ");            

            byte option = 0;
            while (option != 5)
            {
                Console.WriteLine("Elige una opción: ");
                option = Convert.ToByte(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        if (fileNumber < capacity)
                        {
                            Console.Write("Nombre: ");
                            string fileName = Console.ReadLine();
                            files[fileNumber].name = fileName;
                            Console.Write("Tamaño: ");
                            uint fileSize = Convert.ToUInt32(Console.ReadLine());
                            files[fileNumber].size = fileSize;
                            fileNumber++;
                        }
                        else
                        {
                            Console.WriteLine("Máximo alcanzado");
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Ficheros almacenados: ");
                        Console.WriteLine("- Nombre (Tamaño)");  
                        for (int i = 0; i < fileNumber; i++)
                        {
                            Console.WriteLine("- {0} ({1} KB)", files[i].name, files[i].size);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Tamaño mínimo (no incluído): ");
                        uint minFileSize = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Ficheros con un tamaño mayor a {0} KB: ", minFileSize);
                        Console.WriteLine("- Nombre (Tamaño)");
                        for (int i = 0; i < fileNumber; i++)
                        {

                            if (Convert.ToUInt32(files[i].size) > minFileSize)
                            {
                                Console.WriteLine("- {0} ({1} KB)", files[i].name, files[i].size);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Posición del fichero: ");
                        ushort filePosition = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine("- {0} ({1} KB)", files[filePosition-1].name, files[filePosition-1].size);
                        break;
                    default:
                        Console.WriteLine("No hay ninguna opción definida para ese valor");
                        break;
                }
            }               
        }
    }
}
