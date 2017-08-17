using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Forms
    {
        public const double pi = Math.PI;
        protected double a, b;

        public Forms (double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public abstract double Area();
    }
}
