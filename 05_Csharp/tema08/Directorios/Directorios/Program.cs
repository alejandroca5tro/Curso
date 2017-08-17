using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorios
{
    class Program
    {
        static void Main(string[] args)
        {
            string miDirectorio = @"C:\";

            if (!Directory.Exists(miDirectorio))
            {
                Directory.CreateDirectory(miDirectorio);
            }

            string[] fileList;
            fileList = Directory.GetFiles(miDirectorio);
            foreach (string file in fileList)
            {
                Console.WriteLine(file);
            }
            Console.ReadLine();

            DirectoryInfo dir = new DirectoryInfo(miDirectorio);

            FileInfo[] infoFicheros = dir.GetFiles();
            foreach (FileInfo file in infoFicheros)
            {
                Console.WriteLine(file.FullName);
                Console.WriteLine(file.CreationTime);
            }
            Console.ReadLine();
        }
    }
}
