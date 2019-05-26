using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IterationLoopDrill
{
    class Program
    {
        private static int i;
        static void Main(string[] args)
        {
            Console.WriteLine("\n");                      //new line for space
            Console.WriteLine("IterationLoop Drill");     //Header
            Console.WriteLine("\n");                      //new line for space

            //One diminsion array of strings

            string[] myArray = { "fast", "cool", "fun", };                                                  //String for drill
            Console.WriteLine("What is the name of your favorite muscle car:");                             //Writes text to screen 
            string carName = Console.ReadLine();                                                            //returns user input and issigns it ti carName
          
            for (int i = 0; i < myArray.Length; i++)                                            //start of for loop, issigns i as 0 and then adds 1 for length of array
            {
                Console.WriteLine("I agree, " + carName + "'s are " + myArray[i] + ".");        //writes to screen text plus user input for each string in array
            }

            Console.WriteLine("Press ener to continue...");                                      //writes directions to screen
            Console.ReadLine();                                                                  //waiting for user to press enter
            Console.Clear();                                                                     //clears screen

            //Infinite loop...if wrong

            Console.WriteLine("\n");                                                                              //new line for space
            Console.WriteLine("Who is cooler, Ren or Stimpy? Beware--the wrong answer will run forever:");        //Writes text to screen 
            string coolCharacter = (Console.ReadLine()).ToUpper();         //takes user input, changes it to all uppercase and assigns it coolCharacter
            for (int i = 0; ; i++)                                         // start of for loop
            {
                if (coolCharacter == "REN")                                 //check if REN is true
                {
                    Console.WriteLine("That's right. Ren was correct!! You know your stuff!"); //REN is true, print text 
                    break;
                }
                else
                {
                    Console.WriteLine("Noooooo, not " + coolCharacter + ". You are now caught in an infinate loop!");//if REN is false then print text
                }
            }
            Console.WriteLine("\n");                            //new line for space
            Console.WriteLine("Press enter to continue...");    //writes directions to screen
            Console.ReadLine();                                 //waiting for user to press enter
            Console.Clear();                                    //clears screen


            //Comparison less than

            int[] numBer = { 15, 10, 20, 35, 42, 49, 56, 77 };          //array for drill

            //starts at item  0 index; loop keeps running through lenght of array; add 1 to next int
            Console.WriteLine("\n");                                                                          //new line for space
            Console.WriteLine("Here are the numbers from my array. 15, 10, 20, 35, 42, 49, 56 and 77 ");      //prints array to screen
            Console.WriteLine("\n");                                                                          //new line for space
            Console.WriteLine("All numbers in this array that are less than 42 will be displayed: ");         //prints text to screen
            Console.WriteLine("\n");                                                                          //new line for space
            for (int i = 0; i < numBer.Length; i++)                 //start of for loop, assigns i=0 then adds 1 to i for each loop
            {
                if (numBer[i] < 42)                                 //check to see if i is less than 42
                {  
                    Console.WriteLine(numBer[i]);                   //if true then then write i 
                }
            }
            Console.WriteLine("\n");                                                                            //new line for space
            Console.WriteLine("Press enter to continue...");                                                    //directions to user
            Console.ReadLine();                                                                                 //waiting for user to press enter
            Console.Clear();                                                                                    //clears screen

            //Comparison less than or equal to

            int[] numBar2 = { 15, 10, 20, 35, 42, 49, 56, 77 };         //array for srill
            Console.WriteLine("\n");                                                                            //new line for space
            Console.WriteLine("Here are the numbers from my array. 15, 10, 20, 35, 42, 49, 56 and 77 ");        //prints array to screen
            Console.WriteLine("\n");                                                                            //new line for space
            Console.WriteLine("All numbers in the array that less than or equal to 42 will be displayed: ");    //prints text to screen
            Console.WriteLine("\n");                                                                            //new line for space
            for (int i = 0; i < numBar2.Length; i++)            //start of for loop, assigns i=0 then adds 1 to i for each loop
            {
                if (numBar2[i] <= 42)                           //check to see if i is less than or equal to 42
                {
                    Console.WriteLine(numBar2[i]);              //if true then then write i 
                }
            }
            Console.WriteLine("\n");                                                                              //new line for space
            Console.WriteLine("Press enter to continue...");                                                      //directions to user
            Console.ReadLine();                                                                                   //waiting for user to press enter
            Console.Clear();                                                                                      //clears screen

            //Unique string loop









            List<string> myList = new List<string>() { "John", "Paul", "George", "Ringo"};                      //string array for drill and issigns to myList
            Console.WriteLine("\n");                                                                            //new line for space
            Console.WriteLine("                              *****HINT****");                                   //text to screen
            Console.WriteLine("\n");                                                                            //new line for space
            Console.WriteLine("                     John, Paul, George and Ringo");                             //text to screen
            Console.WriteLine("\n");                                                                            //new line for space
            Console.WriteLine("Enter the first name of any member of the Beatles rock group to find their index in the list.");//text to screen
            string fname = Console.ReadLine();                            //takes user input and assigns it to fname
            int index = myList.IndexOf(fname);                            //finds index of fname in myList array               
            for (int i = 0; i <= myList.Count; i++)                       //start of for loop, assigns i =  0 and adds 1 to i for each loop
            {
                if (index >= 0 && index < myList.Count)                   //check for match,if true, get index  
                {
                    Console.WriteLine("His index in the list is {0}.", index); //writes text and fname to screen
                    break;
                }
                else
                {
                    Console.WriteLine("I gave you a hint...Try again.");//if false, write to screen
                    break;
                }
            }
            Console.WriteLine("Press enter to continue...");                                                      //directions to user
            Console.ReadLine();                                                                                   //waiting for user to press enter
            Console.Clear();                                                                                      //clears screen















            //Identical string list

            List<string> memName = new List<string>() { "Glenn", "Don", "Don", "Joe", "Randy" };                    //string array for drill
            Console.WriteLine("           **********HINT********");                                                 //write text to screen
            Console.WriteLine("           Glenn Fry, Don Henley, Don Felder, Joe Walsh and Randy Meisner");         //write text to screen
            bool name = false;                                                                                      //assigns name as false
            Console.WriteLine("Enter only the first name any of the band members of the Eagles to see their index in the list."); //text to screen
            string bandfname = Console.ReadLine();                                                              //takes user input and assigns it to bandfname
            for (int i = 0; i < memName.Count; i++)                                                         //start of for loop, assigns i =  0 and adds 1 to i for each loop
            {
                if (bandfname == memName[i])                                                                        
                {
                    name = true;                                                                                    //if name matches      
                    Console.WriteLine("The index # is " + i);                                                       //write index of name
                    Console.ReadLine();
                }
            }
            if (name == false)                                                                                       //name doesnt match
            {
                Console.WriteLine("That is not a member of the band.");                                              //write text to screen       
                Console.WriteLine("Press enter to continue...");                                                     //directions to user
                Console.ReadLine();                                                                                  //waiting for user to press enter
                Console.Clear();                                                                                     //clears screen
            }


            //Two identical string list using foreach


            Dictionary<int, int> dupNum = new Dictionary<int, int>();

            int[] test = new int[] { 1, 1, 1, 2, 2, 3, 4, 5, 6 };                  // Array list
            Console.WriteLine("This is the array list 1, 1, 1, 2, 2, 3, 4, 5, 6"); //writes array to screen

                
            foreach (int duplicate in test)                                        // Start of loop and assigns value of test to value
            {
                if (dupNum.ContainsKey(duplicate))                                // Check if we have found this key before
                {
                   dupNum[duplicate]++;                                           // Key exists. Add number of occurrences for this key by one
            }   
                else
                {                       
                    dupNum.Add(duplicate, 1);                                     // This is a new key so add it. Number 1 indicates that this key has been found one time
            }  
            }                
            foreach (int num in dupNum.Keys)                                      // Start foreach dupclicate to writeline
            {
            Console.WriteLine("Integer " + num.ToString() + " was found " + dupNum[num].ToString() + " times");// Write to scrren integer, text and how many times it accured
            }
            Console.WriteLine("We are done. Thank you for playing. Press enter to continue...");    //write text to screen
            Console.ReadLine();                                                                     //waiting for user to press enter
        }
    }
}

