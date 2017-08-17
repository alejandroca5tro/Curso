using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClasses01
{
    public class Door
    {
        public int Thickness { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }
        public bool Open { get; set; }
        

        public Door()
        {
            Thickness = 23;
            Width = 26;
            Height = 54;
            Color = "azul";
            Open = true;

        }

        public Door(int x, int y)
        {
            Width = x;
            Height = y;
        }

        public void toOpen()
        {
            Open = true;
        }
        public void toClose()
        {
            Open = false;
        }
        public void showState()
        {
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Alto: {0}", Height);
            Console.WriteLine("Ancho: {0}", Width);
            Console.WriteLine("Abierta: {0}", Open);
        }
    }
}
