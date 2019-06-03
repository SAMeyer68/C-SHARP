using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrillPg126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Drill Page 126");
            Console.WriteLine("\n");
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
}
