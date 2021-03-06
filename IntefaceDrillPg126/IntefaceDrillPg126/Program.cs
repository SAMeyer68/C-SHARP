﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadDrillPage129
{
    class Program
    {
        static void Main(string[] args)
        {                     
            Console.WriteLine("Overload Operator One Drill");
            Console.WriteLine("\n");
            Employee employeeId1 = new Employee(12345);
            Employee employeeId2 = new Employee(1234);
            if (employeeId1 == employeeId2)
                Console.WriteLine("Both employees have the same Employee ID.");
            else
                Console.WriteLine("Each employee has a unique Employee ID.");
            Console.ReadLine();                                                               
        }
    static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
}
