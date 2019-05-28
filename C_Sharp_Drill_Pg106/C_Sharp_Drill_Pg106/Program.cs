using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Drill_Pg106
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> iList = new List<int>() { 10, 15, 20, 25, 30, 35, 40 };       //integer list
            Console.WriteLine("\n");                                                //new line for space
            Console.WriteLine("My integer list of numbers to devide by are 10, 15, 20, 25, 30, 35 and 40. ");
            Console.WriteLine("\n");                                                //new line for space

            try                                                                             //start try catch method for exception errors
            {
                Console.WriteLine("Enter a number to divide each integer in the list: ");   //write text to screen
                int userNum = Convert.ToInt32(Console.ReadLine());             //takes user input, converts it to int32 and assigns it to userNum
                for (int i = 0; i < iList.Count; i++)                          //start of i loop count to read all integers in List
                {
                    int answer = iList[i] / userNum;                            //takes each integer, devides by userNum and assigns to answer           
                    Console.WriteLine(iList[i] + " divided " + userNum + " equals " + answer); //write text, numbers and answer to screen
                }
                Console.WriteLine("\n");                                                //new line for space
                Console.WriteLine("Press enter to end...");                             //text to screen
                Console.ReadLine();                                                     //waiting for user to hit enter
            }
            catch (FormatException ex)                                              //catches format input error
            {
                Console.WriteLine(ex.Message);                                      //writes to screen exception error if any
            }
            catch (DivideByZeroException e)                                         //catches divide by zero input error
            {
                Console.WriteLine(e.Message);                                       //writes to screen exception error if any
            }
            Console.ReadLine();                                                     //waiting for user to hit enter
        }
    }
}
