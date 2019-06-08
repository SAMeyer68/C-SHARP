using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogDrillPage154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Log Drill");                                 //write to screen
            Console.Write("Please enter a number between 1 and 1000:  ");    //write to screen
            string text = Console.ReadLine();                               //takes user input and assigns it to text
            File.WriteAllText(@"C:\Users\Steven\Desktop\TestLogDrillFolder\logdrill.txt", text); //writes text to folder at address
            string file = File.ReadAllText(@"C:\Users\Steven\Desktop\TestLogDrillFolder\logdrill.txt"); //reads text in file at address and assigns it file
            Console.WriteLine(file);                                         //writes file to screen
            Console.WriteLine("Press enter to exit...");                     //write to screen
            Console.ReadLine();                                              //waitin user to press enter
        }
    }
}
