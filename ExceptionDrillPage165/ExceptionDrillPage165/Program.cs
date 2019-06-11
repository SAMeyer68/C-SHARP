using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDrillPage165
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your age?");                                              //write to screen
                    int age = int.Parse(Console.ReadLine());                                             //assigns user input to variable name age and converts user input to int
                    if (age <= 0)                                                                        //checks for positive number
                    {
                        Console.WriteLine("Please enter a positive number");                             //write to screen
                        continue;
                    }
                    Console.WriteLine("Is your birthday before {0}, please answer true or false", DateTime.Now.ToString("MM/dd")); //asks user if birthday is before todays date
                    bool yesNo = Convert.ToBoolean(Console.ReadLine());                                  //converts users answer to bool.
                    if (!yesNo)                                                                          //if not tru or false then break
                    {
                        Console.WriteLine("You were born in {0}", DateTime.Now.Year - 1 - age);          //write to screen year 
                        break;
                    }
                    Console.WriteLine("You were born in {0}", DateTime.Now.Year - age);                  //write to screen year
                    break;                                                                               //exits
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please re-enter in correct format...");                           //write to screen
                }
            }
            Console.WriteLine("Press enter to exit...");                                                 //write to screen
            Console.ReadLine();
        }
    }
}
