using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("DateTime One Drill");                                            //write to screen
            Console.WriteLine("\n");                                                            //new line
            DateTime time = DateTime.Now;                                                       // gets real DateTime from computer and assigns to variable time
            Console.WriteLine("The date and time right now is:  " + time);                      //write to screen
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Please enter a number of hours that will be added to the current time:  ");   //write to screen
            Console.WriteLine("\n");                                                            //new line
            string hours = Console.ReadLine();                                                  //gets user input and assigns to string hours
            Console.WriteLine("\n");                                                            //new line
            Int32.TryParse(hours, out int addNumber);                                           //assigns hours to int32 addNumber
            DateTime newTime = DateTime.Now;                                                    //Gets Datetime and assigns to newTime
            newTime = newTime.AddHours(addNumber);                                              //assigns newTime to addNumber and newTime
            Console.WriteLine("The new date and will be:  " + newTime);                         //write to screen
            Console.WriteLine("\n");                                                            //new line
            Console.WriteLine("Press enter to exit...");                                        //write to screen
            Console.ReadLine();
        }
    }
}
