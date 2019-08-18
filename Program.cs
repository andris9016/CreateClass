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

            Employee kovacs = new Employee("Géza", DateTime.Now, Gender.Male, "léhűtő", 1000);
            kovacs.Room = new Room(111);
            Employee kovacs2 = (Employee)kovacs.Clone();
            kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(kovacs);
            Console.WriteLine(kovacs.Room.RoomNumber);
            Console.WriteLine(kovacs2);
            Console.WriteLine(kovacs2.Room.RoomNumber);
            Console.ReadKey();

        }
    }
}
