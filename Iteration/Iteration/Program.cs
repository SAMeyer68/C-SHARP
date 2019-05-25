using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IterationLoopDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("IterationLoop Drill");
            Console.WriteLine("\n");

            //One diminsion array of strings

            string[] myArray = { "fast", "cool", "fun", };
            Console.WriteLine("What is the name of your favorite muscle car:");
            string carName = Console.ReadLine();
          
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("I agree, " + carName + "'s are " + myArray[i] + ".");
            }

            Console.WriteLine("Press ener to continue...");
            Console.ReadLine();
            Console.Clear();

            //Infinite loop...if wrong
            Console.WriteLine("\n");
            Console.WriteLine("Who is cooler, Ren or Stimpy? Beware--the wrong answer will run forever:");
            string coolCharacter = (Console.ReadLine()).ToUpper();
            for (int i = 0; ; i++)
            {
                if (coolCharacter == "REN")
                {
                    Console.WriteLine("That's right. Ren was correct!! You know your stuff!");
                    break;
                }
                else
                {
                    Console.WriteLine("Noooooo, not " + coolCharacter + ". You are now caught in an infinate loop!");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();


            //Comparison less than

            int[] numBer = { 15, 10, 20, 35, 42, 49, 56, 77 };

            //starts at item  0 index; loop keeps running through lenght of array; add 1 to next int
            Console.WriteLine("\n");
            Console.WriteLine("Here are the numbers from my array. 15, 10, 20, 35, 42, 49, 56 and 77 ");
            Console.WriteLine("\n");
            Console.WriteLine("All numbers in this array that are less than 42 will be displayed: ");
            Console.WriteLine("\n");
            for (int i = 0; i < numBer.Length; i++)
            {
                if (numBer[i] < 42)
                {  
                    Console.WriteLine(numBer[i]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            //Comparison less than or equal to

            int[] numBar2 = { 15, 10, 20, 35, 42, 49, 56, 77 };
            Console.WriteLine("\n");
            Console.WriteLine("Here are the numbers from my array. 15, 10, 20, 35, 42, 49, 56 and 77 ");
            Console.WriteLine("\n");
            Console.WriteLine("All numbers in the array that less than or equal to 42 will be displayed: ");
            Console.WriteLine("\n");
            for (int i = 0; i < numBar2.Length; i++)
            {
                if (numBar2[i] <= 42)
                {
                    Console.WriteLine(numBar2[i]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            //Unique string loop

            List<string> myList = new List<string>() { "John", "Paul", "George", "Ringo"};
            Console.WriteLine("\n");
            Console.WriteLine("                              *****HINT****");
            Console.WriteLine("\n");
            Console.WriteLine("                     John, Paul, George and Ringo");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the first name of any member of the Beatles rock group to find their index in the list.");
            string fname = Console.ReadLine();
            int index = myList.IndexOf(fname);
            for (int i = 0; i <= myList.Count; i++)
            {
                if (index >= 0 && index < myList.Count)
                {
                    Console.WriteLine("His index in the list is {0}.", index);
                    break;
                }
                else
                {
                    Console.WriteLine("I gave you a hint...Try again.");
                    break;
                }
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            //Identical string list

            List<string> memName = new List<string>() { "Glenn", "Don", "Don", "Joe", "Randy",};
            Console.WriteLine("           **********HINT********");
            Console.WriteLine("           Glenn Fry, Don Henley, Don Felder, Joe Walsh and Randy Meisner");
            bool name = false;
            Console.WriteLine("Enter only the first name any of the band members of the Eagles to see their index in the list.");
            string bandfname = Console.ReadLine();
            for (int i = 0; i < memName.Count; i++)
            {
                if (bandfname == memName[i])
                {
                    name = true;
                    Console.WriteLine("His index in the list is " + i);
                    Console.ReadLine();
                }
            }
            if (name == false)
            {
                Console.WriteLine("Sorry, but the entered name is not a member of the Eagles band...");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }

            //STRING LIST - TWO IDENTICAL STRINGS - FOR EACH LOOP

            List<string> carList = new List<string>() {"Chevy", "Chevy", "Ford", "Dodge" };
            Console.WriteLine("The string for this exercise is Chevy, Chevy, Ford, Dodge");
            var duplicates = new List<string>();
            foreach (string item in carList)
            {
                if (!duplicates.Contains(item))
                {
                    duplicates.Add(item);
                    Console.WriteLine("YEP! We have a match!!!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("There is NOT a duplicate.");
                    Console.ReadLine();
                }
            }
            foreach (string match in duplicates)
            {
                Console.WriteLine("The Match is {0}.", match);
            }
            Console.WriteLine("We are done. Thank you for playing. Press enter to continue...");
            Console.ReadLine();
        }
    }
}

