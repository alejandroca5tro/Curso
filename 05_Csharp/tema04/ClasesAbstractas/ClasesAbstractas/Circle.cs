using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Circle : Forms
    {
        public Circle(double radio):base(radio, 0)
        {

        }
        public override double Area()
        {
            return pi * a * a;
        }
    }
}
