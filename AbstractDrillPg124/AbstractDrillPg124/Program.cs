using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrillPg124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("AbdtractDrillPg124");
            Console.WriteLine("\n");
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.WriteLine("\n");
            Console.WriteLine("Hit enter to exit...");
            Console.ReadLine();
        }
    }
}
