using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    //Declarar una clase llamada Circunferencia 
    class Circunferencia
    {
        //que tenga como atributo privado el radio de tipo real
        private double radius=0;

        //y los siguientes métodos
        //a) Calcular el área
        public double calculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        //b) Calcular el perímetro
        public double calculatePerimeter()
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }

        //c) Método para modificar el radio
        public void modifyRadius(double r)
        {
            radius = r;
        }

        //d) Método para consultar el valor del radio
        public double checkRadiusValue()
        {
            return radius;
        }
    }
}
