using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //enum weekDays
    //{
    //    Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo
    //}


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("El día de la semana es {0}", weekDays.Miércoles);
            //Console.WriteLine("que equivale a {0}", (int)weekDays.Miércoles);
            //Console.ReadKey();

            Alumno student = new Alumno("Edison", 2, 23, Sexo.Masculino);
            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }
    }
}
