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
            Console.WriteLine("Interface Drill Page 126");                                      //writes to screen
            Console.WriteLine("\n");                                                            //new line
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };  //assigns new names to variables nad then to employee
            employee.SayName();                                                                 //assigns employee to SayName
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Press enter to exit...");                                        //writes to screen
            Console.ReadLine();                                                                 //waiting user input
        }

        static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
}
