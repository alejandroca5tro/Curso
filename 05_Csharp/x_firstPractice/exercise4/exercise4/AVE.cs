using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    //AVE
    class AVE : ANIMAL
    {        
        public AVE(string k, string n, double w, int c, string q) : base(k, n, w, c, q)
        {
        }

        //Método
        //Volar: : mostrará por pantalla ‘Estoy volando’;
        public void toFly()
        {
            Console.WriteLine("'Estoy volando'");
        }
    }
}
