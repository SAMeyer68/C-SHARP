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
            Console.WriteLine("\n");                                         //new line
            Console.WriteLine("AbdtractDrillPg124");                         //header
            Console.WriteLine("\n");                                         //new line
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //assigning name to employee
            employee.SayName();                                              //implement SayName method from employee class
            Console.WriteLine("\n");                                         //new line
            Console.WriteLine("Hit enter to exit...");                       //write to screen
            Console.ReadLine();                                              //waiting user input
        }
    }
}
