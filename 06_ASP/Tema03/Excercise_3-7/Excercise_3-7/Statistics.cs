using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_7
{
    public class Statistics
    {
        private int n1;
        private int n2;
        private int n3;

        public Statistics(int n1, int n2, int n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        public int add()
        {
            return this.n1 + this.n2 + this.n3;
        }     

        public decimal average()
        {
            decimal av = add()/ 3;
            return av;
        }
    }
}
