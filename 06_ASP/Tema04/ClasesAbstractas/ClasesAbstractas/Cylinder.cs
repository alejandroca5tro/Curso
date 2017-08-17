using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Cylinder:Circle
    {
        public Cylinder(double radio, double height) : base(radio)
        {
            b = height;
        }
        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * a * b);
        }
    }
}
