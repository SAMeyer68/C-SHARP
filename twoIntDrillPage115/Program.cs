using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoIntDrillPage115
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("\n");                                                                    //new line
            Console.Write("Drill page 115");                                                        //write text to screen
            Console.Write("\n");                                                                    //new line
            Console.Write("\n");                                                                    //new line
            Console.Write("Enter first integer number and press enter. ");                          //write text to screen
            string input1 = Console.ReadLine();                                         //takes user input in string format and assigns to input1
            Int32.TryParse(input1, out int num1);                                       //takes input1, TryParse to int32 and assigns it to num1

            Console.Write("\n");                                                                    //new line
            Console.Write("Enter the second integer number or leave blank and press enter. ");      //write text to screen
            string input2 = Console.ReadLine();                                         //takes user input in string format and assigns to input2
            Int32.TryParse(input2, out int num2);                                       //takes input1, TryParse to int32 and assigns it to num2
            Console.Write("\n");                                                                    //new line

            Math1 ans = new Math1();                                                    //calls Math1 class and assigns each divAns to ans
            ans.divAns(num1, num2);                                                     //calls overload ans from Math1 class

            Console.ReadLine();                                                         //waiting for user to hit enter
            int result1, result2;
            ans.Out(num1, num2, out result1, out result2);
            Console.Write("\n");                                                        //new line
            Console.WriteLine( num1 + " plus " + num2 + " = {0}", result1);             //writes text and result to screen
            Console.Write("\n");                                                        //new line
            Console.WriteLine( + num1 + " * " + num2 + " = {0}", result2);              //writes text and result to screen
            Console.Write("\n");                                                        //new line
            Console.ReadLine();                                                         //waiting for user to hit enter

            int Ans3 = Math2.Number3(num2);                                             //takes num2 from class Math2 and assigns it to Ans3
            Console.Write("\n");                                                        //new line
            Console.WriteLine( num2 + " cubed equals {0}", Ans3);                       //writes text and result to screen
            Console.Write("\n");                                                        //new line
            Console.WriteLine("Press enter to exit...");                                //write text to screen
            Console.ReadLine();                                                         //waiting for user to hit enter
        }
    }
}
