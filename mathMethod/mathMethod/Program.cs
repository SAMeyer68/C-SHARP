using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathCal = new Math();                                                          //calling class Math and assigning methods to mathCal
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Please enter a number for math each operation... ");             //message to screen
            Console.WriteLine("\n");                                                            //new line
            double number = Convert.ToDouble(Console.ReadLine());               //takes user input, converts it to ToDouble and assigns it to number
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Your number " + number + " plus 100, equals " +(mathCal.Add(number)));//text, user number and answer to screen
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Your number " + number + " tripled is " + mathCal.triple(number));//text, user number and answer to screen
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Your number "  + number + " divided by 2 is " + mathCal.byTwo(number));//text, user number and answer to screen
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Thank God for Google...");                                       //message to screen
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Press enter to exit.");                                          //message to screen
            Console.ReadLine();                                                                 //waiting user input
        }
    }
}
