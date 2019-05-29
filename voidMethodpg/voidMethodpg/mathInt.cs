using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethodpg
{
    public class mathInt
    {       
        public double result { get; set; }                                  //makes double result public
        public void Add(int numOne, int numTwo)                             //assigns integers numOne and numTo from Add
        {
            double result;                                                  //assigns how max digits results can have
            result = numOne + numTwo;                                       //assigns the sum of numOne and numTwo to result
            Console.WriteLine("\n");                                        //new line
            Console.WriteLine("The second integer is " + numTwo);           //writes text and numTwo to screen
            Console.WriteLine("\n");                                        //new line
            Console.WriteLine("Press enter to exit...");                    //writes to screen
        }
    }
}
