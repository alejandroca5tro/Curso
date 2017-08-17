using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_02
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
            songType[] songs = new songType[99];
            songs[23].artist = "Bob Dylan";
            songs[0].artist = "U2";
        }
    }
}
