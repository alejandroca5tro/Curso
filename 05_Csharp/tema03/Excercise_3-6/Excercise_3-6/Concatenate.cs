using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3_6
{
    public class Concatenate
    {
        private string name;
        private string familyName;

        public Concatenate(string nam, string fam)
        {
            this.name = nam;
            this.familyName = fam;
        }

        public string toConcatenate()
        {
            return this.name + " " + this.familyName;
        }
    }
}
