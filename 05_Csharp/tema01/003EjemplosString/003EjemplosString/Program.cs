using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003EjemplosString
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found, gameCompleted, gameOver;
            int level=0, lastLevel=10, enemies = 0,lifes =5;
            gameCompleted = (enemies==0) && (level==lastLevel);
            if (lifes == 0) gameOver = true;

            //string phrase = "Hola mundo";
            //Console.WriteLine("la frase es \"{0}\"", phrase);
            //Console.Write("Introduce una frase: ");
            //phrase = Console.ReadLine();
            //Console.WriteLine("Ahora la frase es \"{0}\"", phrase);
            //if (phrase == "Pepe")
            //{
            //    Console.WriteLine("Hola Pepe");
            //}
            //Console.ReadLine();
        }
    }
}
