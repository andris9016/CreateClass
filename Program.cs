using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andris = new Person("Andris", new DateTime(1990,12,09), Gender.Male);
            Console.WriteLine(andris);
            Console.WriteLine(andris.Gender);

            Employee evi = new Employee("Évi", new DateTime(1997, 12, 05), Gender.Female, "general manager", 2500);
            Console.WriteLine(evi);
            Console.ReadLine();
        }
    }
}
