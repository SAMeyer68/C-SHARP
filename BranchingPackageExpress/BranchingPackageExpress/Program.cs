using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingPackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");  //prints Header

                //Package weight

            Console.WriteLine("Enter package weight: ");            //prints to screen "Enter package weight:
            string PackWt = Console.ReadLine();              //takes input from user and assigns it to PackWt
            double pkWeight = Convert.ToDouble(PackWt);         // converts input string to double and assigns that to pkWeight

                //Weight check

            if (pkWeight > 50)          //if package is over 50 then do the folowing if not move to the next block of code
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.  Have a good day."); //print to screen that package is too heavy
                Console.ReadLine();         //waiting for user input
                System.Environment.Exit(0); //exits
            }

            //Package diminsions 

            Console.WriteLine("Enter package width: ");             //This block of 
            string packWth = Console.ReadLine();                    //code asks
            double packWidth = Convert.ToDouble(packWth);           //the user for
            Console.WriteLine("Enter package height: ");            //the diminisions
            string pHeight = Console.ReadLine();                    //and assigns
            double packHt = Convert.ToDouble(pHeight);              //the inputs to
            Console.WriteLine("Enter package length: ");            //height
            string packLth = Console.ReadLine();                    //width
            double packLength = Convert.ToDouble(packLth);          //length 

            //Diminsion check

            double packDimsn = packWidth + packHt + packLength;                             //assigning diminsion totals to packDimsn
            if (packDimsn > 50)                                                             // check if over 50                       
            {
                Console.WriteLine("Package is too big to be shipped via Package Express."); //if over 50 it prints that package is too big
                Console.ReadLine();                                                         //waits for user input
                System.Environment.Exit(0);                                                 //exits program
            }

            //Quote calc

            else
            {
                double total = packDimsn * pkWeight / 100;                      // assigning dimmension and weight calc to total
                Console.WriteLine("You estimated total for shipping this package is:"); //write to screen your total
                Console.WriteLine("$ {0:0.00}", total);                         // print total
                Console.WriteLine("Thank you.");                                // print kind expression
                Console.ReadLine();                                             // waiting for user input
            }
        }
    }
}
