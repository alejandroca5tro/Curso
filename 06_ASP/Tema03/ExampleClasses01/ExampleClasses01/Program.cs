using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClasses01
{
    class Program
    {
        static void Main(string[] args)
        {
            Door door1 = new Door();
            door1.Height = 23;
            door1.Width = 45;
            door1.Color = "rojo";

            door1.toOpen();
            door1.showState();

            Gate gate1 = new Gate();

            Door door2 = new Door();

            Door door3 = new Door();
            
        }
    }
}
