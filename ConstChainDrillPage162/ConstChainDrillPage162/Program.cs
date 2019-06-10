using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstChainDrillPage162
{
    class Program
    {
        const string Key = "This Key String";
        static void Main(string[] args)
        {
            const string carName = "Tuckers";                                                               //assigns const tuckers to carName
            Class1 classOne = new Class1("Auto");                                                           //calls class1
            var carsMade = classOne.Cars;                                                                   //assigns classOne
            Console.WriteLine("Number of {0} cars made was {1}", carName, carsMade);                        //write to screen
            Console.WriteLine("Press enter to exit...");                                                    //write to screen
            Console.Read();                                                                                 //waiting for user to press enter
        }
    }
}
