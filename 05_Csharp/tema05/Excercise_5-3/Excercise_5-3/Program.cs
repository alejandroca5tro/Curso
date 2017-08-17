using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //I define a variable for the file name. It is not necessary, but it will help me later to show the file name.
            string fileName;
            fileName = "frases.txt";

            //Develop the code that writes in the file
            StreamWriter fileToWrite;
            fileToWrite = File.CreateText(fileName);
            string textLine = "";
            Console.WriteLine("Escribe frases:");
            do
            {
                textLine = Console.ReadLine();
                if (textLine != "")
                {
                    fileToWrite.WriteLine(textLine);
                }
            }
            while (textLine != "");
            fileToWrite.Close();

            //Development code that reads the file
            //StreamReader fileToRead;
            //string line;
            //fileToRead = File.OpenText(fileName);
            //Console.WriteLine("Este es el contenido del fichero {0}", fileName);
            //do
            //{
            //    line = fileToRead.ReadLine();
            //    if (line != null) Console.WriteLine(line);
            //} while (line != null);
            //fileToRead.Close();

            //Console.ReadKey();

            //Para añadir al fichero:
            StreamWriter writeToExistingFile;
            writeToExistingFile = File.AppendText(fileName);
            writeToExistingFile.WriteLine("Otra línea más");
            writeToExistingFile.Close();

            //Leemos lo que se ha vuelto a añadir:
            StreamReader fileToReadAgain;
            string line2;
            fileToReadAgain = File.OpenText(fileName);
            Console.WriteLine("Este es el contenido del fichero {0}", fileName);
            do
            {
                line2 = fileToReadAgain.ReadLine();
                if (line2 != null) Console.WriteLine(line);
            } while (line2 != null);
            fileToReadAgain.Close();

            Console.ReadKey();

        }
    }
}
