using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodDrill114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");                                                             //creates new line
            Console.WriteLine("Math operation pg114");                                           //writes message to screen
            Console.WriteLine("\n");                                                             //creates new line
            Console.WriteLine("Press enter to continue...");                                     //writes message to screen
            Console.ReadLine();                                                                  //waiting for user

            Math Calc = new Math();                                                              //opens Math class and issigns to Calc variable


            int total1 = Calc.SameName(12);                                                      //assigns int sameName to total1
            Console.WriteLine("\n");                                                             //creates new line
            Console.WriteLine("The result of integer 12 - 1 equals... " + total1);               //writes text and result to screen
            Console.WriteLine("Press enter to continue...");                                     //writes message to screen
            Console.ReadLine();                                                                  //waiting for user


            int total2 = Calc.SameName(5.5);                                                     //assigns decimal sameName to total2
            Console.WriteLine("\n");                                                             //creates new line
            Console.WriteLine("The total multiplied by 10.5 equals... " + total2);               //writes text and result to screen
            Console.WriteLine("Press enter to continue...");                                     //writes message to screen
            Console.ReadLine();                                                                  //waiting for user


            int total3 = Calc.SameName("25");                                                    //assigns string sameName to total3
            Console.WriteLine("\n");                                                             //creates new line
            Console.WriteLine("The string value + 1 equals... " + total3);                       //writes text and result to screen
            Console.WriteLine("Press enter to exit...");                                         //writes message to screen
            Console.ReadLine();                                                                  //waiting for user

        }
    }
}
