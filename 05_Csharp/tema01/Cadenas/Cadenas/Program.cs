using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string wholeWord = "Esta es una variable de cadena";
            string upperChain = wholeWord.ToUpper();
            //Console.WriteLine(upperChain);
            string lowerChain = wholeWord.ToLower();
            //Console.WriteLine(lowerChain);
            string insertedChain = wholeWord.Insert(5, "algo de fuera");
            //Console.WriteLine(insertedChain);
            string removeChain = wholeWord.Remove(5, 13);
            //Console.WriteLine(removeChain);
            string replacedChain = wholeWord.Replace("una", "1");
            //Console.WriteLine(replacedChain);
            Console.ReadLine();
        }
    }
}
