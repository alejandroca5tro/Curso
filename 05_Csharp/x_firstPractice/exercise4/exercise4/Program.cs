using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class Program
    {
        //Crear un programa que gestione el ingreso de los animales
        static void Main(string[] args)
        {
            int animalClass;

            string kind;
            string name;
            double weight;
            int cage;
            int age;

            string query;

            //(ingresar dos leones, un tigre y un águila) en el zoológico
            Console.WriteLine("- GESTIÓN DE INGRESO DE ANIMALES -");
            Console.WriteLine();
            Console.WriteLine("Las clases de animal a ingresar son las siguientes: ");
            Console.WriteLine();
            Console.WriteLine("1 - Mamífero");
            Console.WriteLine("2 - Ave");
            Console.WriteLine();
            Console.Write("Elija el número correspondiente a la clase que desea ingresar: ");            
            animalClass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (animalClass)
            {

                //mostrando la ficha técnica y las acciones que cada uno realice.
                case 1:                    
                    Console.WriteLine("Defina los atributos para el mamífero:");
                    Console.WriteLine();
                    Console.Write("- Especie a la que pertenece: ");
                    kind = Console.ReadLine();
                    Console.Write("- Nombre del animal: ");
                    name = Console.ReadLine();
                    Console.Write("- Peso: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("- Jaula en la que el animal es asignado: ");
                    cage = Convert.ToInt32(Console.ReadLine());
                    Console.Write("- Edad del mamífero: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    query = "insert into Animals(AnimalKind, AnimalName, AnimalWeight, Cage, AnimalAge) values(@AnimalKind, @AnimalName, @AnimalWeight, @Cage, " + 8.ToString() + ")";

                    MAMIFERO mammal = new MAMIFERO(kind, name, weight, cage, age, query);

                    Console.WriteLine("La ficha técnica del animal registrado es la siguiente:");
                    Console.WriteLine();
                    mammal.printSheet();
                    Console.WriteLine();
                    mammal.toRoar();
                    Console.WriteLine();

                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Defina los atributos para el ave:");
                    Console.WriteLine();
                    Console.Write("- Especie a la que pertenece: ");
                    kind = Console.ReadLine();
                    Console.Write("- Nombre del animal: ");
                    name = Console.ReadLine();
                    Console.Write("- Peso: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    Console.Write("- Jaula en la que el animal es asignado: ");
                    cage = Convert.ToInt32(Console.ReadLine());                
                    Console.WriteLine();

                    query = "insert into Animals(AnimalKind, AnimalName, AnimalWeight, Cage) values(@AnimalKind, @AnimalName, @AnimalWeight, @Cage)";

                    AVE bird = new AVE(kind, name, weight, cage, query);

                    Console.WriteLine("La ficha técnica del animal registrado es la siguiente:");
                    Console.WriteLine();
                    bird.printSheet();
                    Console.WriteLine();
                    bird.toFly();
                    Console.WriteLine();

                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("No se ha introducido un número válido");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
