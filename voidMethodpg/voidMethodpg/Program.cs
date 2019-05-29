using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethodpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");                                        //new line
            Console.WriteLine("Void Method Drill page 113");                //writes to screen
            Console.WriteLine("\n");                                        //new line
            Console.WriteLine("My 2 integers for this drill is (5,10)");    //writes to screen
            Console.WriteLine("\n");                                        //new line
            Console.WriteLine("Press enter to see the results");            //writes to screen
            Console.ReadLine();                                             //waiting for user to press enter
            mathInt MathInteger = new mathInt();                            //assigns results of MathInteger from class mathInt to new mathInt
            MathInteger.Add(5, 10);                                         //assigns 1st and 2nd integers to Add in MathInteger
            Console.ReadLine();                                             //waiting for user to press enter
        }
    }
}
