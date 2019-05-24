using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList Drill");           //Header
            Console.WriteLine("\n");                        //new line

            //String array index

            string[] sArray1 = { "Red", "Blue", "Yellow" };      //assigning value to sArray1
            Console.WriteLine("Enter a number between 0 and 2 to find out what a primary color is: \n"); //write question to screen
            string value = Console.ReadLine();                   //reads user input and assigns it string value
            if (Int32.TryParse(value, out int index1))           //checks to see if value is valid. if it is then it assigns it out to index1
            {
                if (index1 >= 0 && index1 < sArray1.Length)      //if index1 is between 0-3 (array length) then continue
                {
                    string indexNum = sArray1[index1];           //assigns the index1 number of the Sarray to indexNum
                    Console.WriteLine("{0} is a primary color.", indexNum);     //writes indexNum is a primary color
                }
                else
                {
                    Console.WriteLine("The value entered is not between 0 and 3."); //returns for correct user input
                }
            }
            else
            {
                Console.WriteLine("Try again...0, 1, 2 or 3 only");    //returns for correct user input 
            }
            Console.WriteLine("Press enter to continue.");      //prints to screen directions to continue
            Console.ReadLine();                                 //waits for user input
            Console.Clear();                                    //clears screen after completion

            //INT ARRAY

            int[] iArray1 = { 1960, 1960, 1960, 1960 };                                     //array list
            Console.WriteLine("Pick between 0-3 to see the first year of the Corvair.  ");  //writes directions to screen
            string yearOne = Console.ReadLine();                                            //issigns user input to yearOne
            int Num;
            if (Int32.TryParse(yearOne, out Num))   //checks to see if value is valid. if it is then it assigns it out to Num
            {
                if (Num >= 0 && Num < iArray1.Length)   //if Num is between 0-3 (array length) then continue
                {
                    int numAtIndex = iArray1[Num];     //assigns the array number of Num to numAtIndex
                    Console.WriteLine("The first model year was {0}.", numAtIndex); //writes to screen the first model year was numAtIndex
                }
                else
                {
                    Console.WriteLine("The value entered is not between 0 and 3.");   //returns for correct user input             
                }
            }
            else
            {
                Console.WriteLine("Hmmm...Try again.");     //returns for correct user input
            }
            Console.WriteLine("Press enter to continue.");      //prints to screen directions to continue
            Console.ReadLine();     //waits for user input
            Console.Clear();        //clears screen after completion

            //LIST OF STRINGS

            List<string> listString = new List<string>() { "Chevy", "Ford", "Dodge", "Cadillac", "Ram" }; //assigns values to string
            Console.WriteLine("Enter a number betwen 0 and 4 to find an American car company:");          //writes direction to screen
            string listName = Console.ReadLine();      //assigns user input to listName
            if (Int32.TryParse(listName, out int indexList))  //checks to see if value is valid. if it is then it assigns it out to indexList
            {
                if (indexList >= 0 && indexList < listString.Count)  //verifies indexList is between 0-4
                {
                    string indexValue = listString[indexList];          //assigns the indexList of listString to indexValue
                    Console.WriteLine("{0} is an American car company.", indexValue);//writes indexValue is an american car comapny
                }
                else
                {
                    Console.WriteLine("Please try again, you must pick between 0 and 4.");//returns for correct user input
                }
            }
            else
            {
                Console.WriteLine("Try again...That wasn't one of your options.");//returns for correct user input
            }
            Console.WriteLine("Press enter to continue.");      //prints to screen directions to continue
            Console.ReadLine();     //waits for user input
            Console.Clear();        //clears screen after completion
        }
    }
}
