using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private Room room;
        public decimal Salary { get; set; }
        public string Profession { get; set; }
        public Room Room { get => room; set => room = value; }


        public Employee(string name, DateTime birthDate, Gender gender, string profession, decimal salary)
            : base(name, birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return string.Format("{0} prfession: {1}, salary: {2}",base.ToString(), Profession, Salary);
        }
    }
}
