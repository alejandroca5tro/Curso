using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples02
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime ContractDate { get; set; }
        public decimal Salary { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Name, LastName, ContractDate, Salary, Active);
        }
    }
}
