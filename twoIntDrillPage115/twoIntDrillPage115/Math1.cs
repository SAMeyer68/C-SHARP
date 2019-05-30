using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoIntDrillPage115
{
    public class Math1
    {
        public void divAns(int num1)
        {
            int result;                                                         //declaring local variable result
            result = num1 / 2;                                                  //assigning answer to result
            Console.WriteLine(num1 + " / 2 = " + result + ".");                 //write text and result
        }

        public void divAns(int num1, int num2)                                  //returns variables 
        {
            int result;                                                         //declaring local variable result
            result = (num1 + num2) / 2;                                         //assigns answer of equation to result
            Console.Write("\n");                                                //new line
            Console.WriteLine(num1 + num2 + " / 2 = " + result);                //writes variables, text and result
        }
        public void Out(int num1, int num2, out int result1, out int result2)   //returns all variables in ()
        {
            result1 = num1 + num2;                                              //adds num1 and num2 and issigns sum to results1
            result2 = num1 * num2;                                              //multiplies num1 and num2 and issigns sum to results2
        }
    }
}
