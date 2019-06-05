using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrillPage131
{
    class program
    { 
    static void Main(string[] args)
        {
            Console.WriteLine("GenericDrillPage131");
            Console.WriteLine("\n");

            Employee<string> Title = new Employee<string>();
            List<string> stringList = new List<string>();

            stringList.Add("Junior Developer");
            stringList.Add("Software Developer");        
            stringList.Add("Full Stack Developer");
            Title.Things = stringList;
            stringList.ForEach(Console.WriteLine);

            Employee<int> Salary = new Employee<int>();
            List<int> intList = new List<int>();
            intList.Add(45000);
            intList.Add(60000);
            intList.Add(80000);
            Salary.Things = intList;
            intList.ForEach(Console.WriteLine);
           
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
}
