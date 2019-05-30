using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_Drill_pg117
{
    class Program
    {
        static void Main(string[] args)

        {
            Method1 m = new Method1();                                      //assigns new method
            Console.WriteLine("Please enter a number");                     //write message to screen
            int input1 = Convert.ToInt32(Console.ReadLine());               //converts input to int32 and assigns to input
            m.TestMethod(input1, out int result);                           //sends result back to m
            Console.WriteLine("\n");                                        //creates new line
            Console.WriteLine("First method result: The number you entered divided by two is " + result);  //writes text and result to screen
            Console.WriteLine("\n");                                        //creates new line
            Console.Write("Overloaded method result: " + StaticClass.TestMethod(input1));                  //writes text and result to screen
            Console.Read();                                                 //wait for user to enter
        }
    }
}

