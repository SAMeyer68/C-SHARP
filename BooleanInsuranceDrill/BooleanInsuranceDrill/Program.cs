using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanInsuranceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //Questions

            Console.Write("What is your age? ");                        //asking for age input
            string Age = Console.ReadLine();                            //reading string and assigning it to age
            double driverAge = Convert.ToDouble(Age);                   //convert string age to double and assigning it to driverAge
            Console.Write("Have you ever had a DUI? (yes or no) ");     //asking for yes or no input
            string Dui = Console.ReadLine();                            //taking input and assigning it to Dui
            Console.Write("How many speeding tickets do you have? ");   //asking for number of speeding tickets
            string Ticket = Console.ReadLine();                         //taking input and assigning it to Ticket
            double ticketAmt = Convert.ToDouble(Ticket);                //convert string Ticket and assigning it to ticketAmt

            //Rules for qualification

            bool isQualified = (driverAge > 15 && Dui == "no" && ticketAmt < 3); //Finding if over 15 and no DUI and under 3 tickets
            

             //Results

            Console.WriteLine("Qualified?");                            //prints to screen " qualified?"
            Console.WriteLine("{0}", isQualified.ToString());           //inserts true or false and prints it to screen
            Console.ReadLine();                                         //hold for user input
        
            
        
        }
    }
}
