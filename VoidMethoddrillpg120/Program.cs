using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethoddrillpg120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "John", LastName = "Doe" };
            employee1.SayName();
            Console.Read();
        }
    }
}
