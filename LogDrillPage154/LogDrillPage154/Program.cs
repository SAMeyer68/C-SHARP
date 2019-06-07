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
            Console.WriteLine("Log Drill");
            Console.Write("Please enter a number between 1 and 100:  ");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Steven\Desktop\TestLogDrillFolder\logdrill.txt", text);
            string file = File.ReadAllText(@"C:\Users\Steven\Desktop\TestLogDrillFolder\logdrill.txt");
            Console.WriteLine(file);
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
