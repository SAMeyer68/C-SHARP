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
            Console.WriteLine("Comparison statements");                         //Header


                //While loop

            Console.WriteLine("Guess my number between 1-10"); //print to screen "guess my number 1-10"
            int numBer = Convert.ToInt32(Console.ReadLine());  // takes user input and assigns to numBer
            while (numBer != 9)                                // as long as numBer is not 9 then run the following code
            {
                Console.WriteLine("Nope! Guess again...");                          //write to screen "Nope! Guess again..."
                Console.WriteLine("Guess my number between 1-10?");                 //write screen "guess my number between 1-10?"
                numBer = Convert.ToInt32(Console.ReadLine());                       //takes user input and returns to beginning of while loop to check for correct answer
            }



            //Do while loop

            Console.WriteLine("How many years was the Chevy Corvair produced?");        //write to screen "How many years was the Chevy Corvair produced?"
            int yearsMade = Convert.ToInt32(Console.ReadLine());                        //takes user input, converts to integer 32 and assigns it to yearsMade
            bool years = yearsMade == 10;                                               //asking if yearsMade is equal to 10 and assigning result(true or false) to years

            do                                                                          //start of do-while loop
            {
                switch (yearsMade)                                                      //start of switch statement of yearsMade
                {
                    case 10:                                                            //asking if yearsMade is equal to 10
                        Console.WriteLine("You know your stuff.");                      //if yearsMade equals to 10, then write ""You know your stuff.
                        years = true;
                        break;                                                          //stops continuation of switch statement
                    default:                                                            //If yearsMade does not equal to 10, then continue
                        Console.WriteLine("Nope! Guess again...");                      //If yearsMade does not equal to 10, then write to screen "Nope! Guess again..."
                        Console.WriteLine("How many years was the Chevy Corvair produced?");  //asking for another guess from user
                        yearsMade = Convert.ToInt32(Console.ReadLine());                      //checks input from user to see if it matches with yearsMade
                        break;                                                                //stops continuation of switch statement
                }
            }
            while (!years);                                                                //end of do-while loop

            Console.ReadLine();
        }
    }
}
