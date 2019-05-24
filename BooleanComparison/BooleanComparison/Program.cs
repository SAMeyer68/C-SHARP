using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparison statements");


            //While loop

            Console.WriteLine("Guess my number between 1-10");
            int numBer = Convert.ToInt32(Console.ReadLine());
            while (numBer != 9)
            {
                Console.WriteLine("Nope! Guess again...");
                Console.WriteLine("Guess my number between 1-10?");
                numBer = Convert.ToInt32(Console.ReadLine());
            }



            //Do while loop

            Console.WriteLine("How many years was the Chevy Corvair produced?");
            int yearsMade = Convert.ToInt32(Console.ReadLine());
            bool years = yearsMade == 10;

            do
            {
                switch (yearsMade)
                {
                    case 10:
                        Console.WriteLine("You know your stuff.");
                        years = true;
                        break;
                    default:
                        Console.WriteLine("Nope! Guess again...");
                        Console.WriteLine("How many years was the Chevy Corvair produced?");
                        yearsMade = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!years);

            Console.ReadLine();
        }
    }
}
