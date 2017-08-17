using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ourFile;    
            ourFile = File.CreateText("registroDeUsuarios.txt");
            string textContent = "";
            Console.Write("Escribe el contenido del fichero: ");
            do
            {
                textContent = Console.ReadLine();
                if (textContent.ToUpper() != "FIN")
                {
                    ourFile.WriteLine(textContent);
                }
            }
            while (textContent.ToUpper() != "FIN");

            ourFile.Close();
        }
    }
}

