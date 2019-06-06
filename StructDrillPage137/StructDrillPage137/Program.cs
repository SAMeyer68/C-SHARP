using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrillPage137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 9.2m };          //assigns 9.2 to Amount/converts to decimal in Number and assigns as new Number
            Console.WriteLine("\n");                                 //new line
            Console.WriteLine("The number is  " + number.Amount);    //writes to screen
            Console.WriteLine("\n");                                 //new line
            Console.Write("Press enter to exit...");                 //writes to screen
            Console.WriteLine("\n");                                 //new line
            Console.Read();
        }
    }
}
