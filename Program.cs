using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1
            Console.WriteLine();
            Console.WriteLine("Person 1");           
            Console.Write("@/nHourly Rate: ");
            Console.WriteLine();
            string hourlyRate1 = Console.ReadLine();
            double hourRate1 = Convert.ToDouble(hourlyRate1);
            Console.Write("Hours worked per week: ");
            Console.WriteLine();
            string hoursWorked1 = Console.ReadLine();

            double hoursWeek1 = Convert.ToDouble(hoursWorked1);

            //Person 2
            Console.WriteLine();
            Console.WriteLine("Person 2");          
            Console.Write("Hourly Rate: ");
            Console.WriteLine();
            string hourlyRate2 = Console.ReadLine();
            double hourRate2 = Convert.ToDouble(hourlyRate2);
            Console.Write("Hours worked per week: ");
            Console.WriteLine();
            string hoursWorked2 = Console.ReadLine();
            double hoursWeek2 = Convert.ToDouble(hoursWorked2);



            //Person 1 Calculation

            Console.WriteLine();
            double product1 = hourRate1 * hoursWeek1 ;
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine("{0:0.00}", product1);
            Console.ReadLine();
 

            //Person 2 Calculation

            double product2 = hourRate2 * hoursWeek2 ;
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine("{0:0.00}", product2);
            Console.ReadLine();

            //Salary Comparison

            bool trueOrFalse = product1 > product2;
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine("{0}", trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
