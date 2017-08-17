using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._21
{
    class Program
    {
        struct songType
        {
            public string artist;
            public string title;
            public ushort duration;
            public float fileSize;
        }
        static void Main(string[] args)
        {
            songType song;
            Console.WriteLine("- SONG TAG v.1.0.0 -");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Escribe los datos de la canción a continuación");
            Console.Write("Artista: ");
            song.artist = Console.ReadLine();
            Console.Write("Título: ");
            song.title = Console.ReadLine();
            Console.Write("Duración: ");
            song.duration = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Tamaño del archivo: ");
            song.fileSize = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Recopilación de datos terminada. Los tags son los siguientes: ");            
            Console.WriteLine("           Artista: {0}", song.artist);
            Console.WriteLine("            Título: {0}", song.title);
            Console.WriteLine("          Duración: {0} segundos", song.duration);
            Console.WriteLine("Tamaño del archivo: {0} KB", song.fileSize);
            Console.ReadLine();
        }
    }
}
