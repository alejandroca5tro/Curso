using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza después una aplicación para probar tu clase
            //debe al menos crear 2 objetos de tipo Fecha, utilizando cada uno de los constructores
            Fecha date1 = new Fecha();

            Fecha date2 = new Fecha(3, 7, 2017);

            //y después
            //mostrar las fechas correspondientes en la pantalla
            date1.showDate();

            date2.showDate();

            //modificar la primera
            date1.changeDate(30, 6, 2017);

            // y volver a imprimir los meses en letra de las dos
            date1.showDateMonthWord();

            date2.showDateMonthWord();
        }
    }
}
