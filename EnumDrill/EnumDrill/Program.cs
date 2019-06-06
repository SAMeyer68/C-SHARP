using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any day of the week...");                           //writes to screen
                string dayEntry = Console.ReadLine().ToUpper();                              //assigns user input to dayEntry uppercase
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayEntry);       //parses DaysOfWeek for user input match
                Console.WriteLine("You entered a valid day, which was {0}", day);            //writes to screen
            }
            catch
            {
                Console.WriteLine("That didn't work... did you type the day correctly starting with a capital letter?");//writes to screen if no match
            }
                Console.WriteLine("Press enter to exit...");                                  //writes to screen
                Console.ReadLine();                                                           //waiting user to press enter
        }
    }
    enum DaysOfWeek                                                                           //assigns days to DaysOfWeek enum
    {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY
    }
}
