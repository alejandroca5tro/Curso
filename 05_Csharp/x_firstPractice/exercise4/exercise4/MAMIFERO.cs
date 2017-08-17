using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    //Y las siguientes clases que derivarán de la anterior:
    // MAMIFERO

    class MAMIFERO:ANIMAL
    {
        //Atributo:
        //Edad del mamífero(nt)
        public int age;

        public MAMIFERO(string k, string n, double w, int c, int a, string q) : base(k, n, w, c, q)
        {
            this.age = a;     
        }

        //Método:
        //Imprimir ficha añadiendo la nueva propiedad
        public override void printSheet()
        {
            base.printSheet();
            Console.WriteLine("EDAD: {0} años", age);
        }

        //Rugir : mostrará por pantalla ‘Estoy rugiendo’;
        public void toRoar()
        {
            Console.Write("'Estoy rugiendo'");
        }
    }
}
