using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01arraylistexample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList miDiccionario = new SortedList();
            miDiccionario.Add("hello", "hola");
            miDiccionario.Add("home", "casa");

            Console.WriteLine(miDiccionario.IndexOfKey(miDiccionario.IndexOfKey("hello")));

            Hashtable miDiccionario2 = new Hashtable();
            miDiccionario2.Add("Elemento1", "Este es el primer elemento");
            miDiccionario2.Add("casa", "Lugar para vivir");

            Console.WriteLine(miDiccionario2["Elemento1"]);

            List<Empleado> listaEmpleados = new List<Empleado>();

            ArrayList miLista = new ArrayList();
            miLista.Add("Hola");
            miLista.Add("desde");
            miLista.Add("mi Array List");
            miLista.Add("ké");
            miLista.Add("ase");

            foreach (string phrase in miLista)
            {
                Console.WriteLine(phrase);
            }
            Console.WriteLine("La segunda palabra es: {0}", miLista[1]);
            Console.ReadLine();

            miLista.Insert(1, "Otra palabra");            
            foreach (string phrase in miLista)
            {
                Console.WriteLine(phrase);
            }

            Console.ReadLine();

            miLista.Sort();
            foreach (string phrase in miLista)
            {
                Console.WriteLine(phrase);
            }
            Console.ReadLine();

            miLista.Sort();
            miLista.Reverse();
            foreach (string phrase in miLista)
            {
                Console.WriteLine(phrase);
            }
            Console.ReadLine();

            miLista.RemoveAt(1);
            foreach (string phrase in miLista)
            {
                Console.WriteLine(phrase);
            }
            Console.ReadLine();

            miLista.Remove("Hola");
            foreach (string phrase in miLista)
            {
                Console.WriteLine(phrase);
            }
            Console.ReadLine();
        }

    }
}
