using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I will multiply it by 50");

            double multBy50 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(multBy50 + " times 50 = " + (multBy50 * 50));

            Console.WriteLine("Enter a number an I will add 25 to it.");

            decimal add25 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("If you add 25 to that you get " + (add25 + 25));

            Console.WriteLine("Enter another number and I will divide it by 12.5");

            double divBy12Half = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("If you divide it by 12.5 you get " + (divBy12Half / 12.5));

            Console.WriteLine("Enter a number and I will tell you if it is greater than 50");

            bool greaterThan50 = Convert.ToDouble(Console.ReadLine()) > 50;

            Console.WriteLine(greaterThan50);

            Console.WriteLine("Enter a number and I will find you the remainder after dividing it by 7");

            double divide7Remainder = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(divide7Remainder + " / 7 remainder is " + divide7Remainder % 7);


            Console.ReadLine();
        }
    }
}
