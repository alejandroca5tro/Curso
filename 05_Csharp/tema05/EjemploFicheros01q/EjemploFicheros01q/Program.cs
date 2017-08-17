using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFicheros01q
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ourFile;

            ourFile = File.CreateText("test.txt");
            ourFile.WriteLine("ESta es la primera línea del fichero");
            ourFile.Write("Esto es otra");
            ourFile.Write("y esto es la continuación de la anterior");
            ourFile.Close();
        }
    }
}
