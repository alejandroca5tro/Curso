using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClasses01
{
    public class Gate : Door
    {
        public bool Blocked { get; set; }
    
        public void toBlock()
        {
            Blocked = true;
        }
        public void toUnBlock()
        {
            Blocked = false;
        }
        public new void showState()
        {
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Alto: {0}", Height);
            Console.WriteLine("Ancho: {0}", Width);
            Console.WriteLine("Abierta: {0}", Open);
            Console.WriteLine("Bloqueado: {0}", Blocked);
        }
    }
}
