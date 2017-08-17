using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    //Define la clase Fecha
    public class Fecha
    {
        //de acuerdo con las siguientes especificaciones:
        //Atributos:
        //día
        private int day;    
        
        //mes
        private int month;

        //año
        private int year;

        //Constructores:
        //Que inicialice con una fecha fija que tú definas
        public Fecha()
        {
            this.day = 26;
            this.month = 6;
            this.year = 2017;
        }        

        //Que reciba como parámetro los valores para inicializar la fecha
        public Fecha(int d, int m, int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }

        //Métodos públicos:
        //Que permita modificar el valor de la fecha
        public void changeDate(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        //Que muestre en la pantalla la fecha usando el formato dia / mes / año
        public void showDate()
        {
            string day = this.day.ToString();
            string month = this.month.ToString();
            string year = this.year.ToString();
            Console.WriteLine("La fecha es {0} / {1} / {2}", day, month, year);
            Console.ReadKey();
        }

        //Que muestre en la pantalla la fecha poniendo el mes con palabras
        public void showDateMonthWord()
        {
            string day = this.day.ToString();

            string[] monthWord = new string[12];
            monthWord[0] = "Enero";
            monthWord[1] = "Febrero";
            monthWord[2] = "Marzo";
            monthWord[3] = "Abril";
            monthWord[4] = "Mayo";
            monthWord[5] = "Junio";
            monthWord[6] = "Julio";
            monthWord[7] = "Agosto";
            monthWord[8] = "Septiembre";
            monthWord[9] = "Octubre";
            monthWord[10] = "Noviembre";
            monthWord[11] = "Diciembre";
            string month = monthWord[this.month-1];

            string year = this.year.ToString();
            Console.WriteLine("La fecha es {0} de {1} de {2}", day, month, year);
            Console.ReadKey();
        }        
    }
}
