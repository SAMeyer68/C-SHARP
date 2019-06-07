using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaDrillPAge140
{
    class Program
    { 
        public static void Main()
        {
            Console.WriteLine("Lambda Drill");
            Console.WriteLine("\n");
            List<Employee> EmployeeList = new List<Employee>();    //creates new EmployeeList from Employee class perameters 
            EmployeeList.Add(new Employee() { FirstName = "Joe", LastName = "DiMagio", ID = 1 });       //assigns variable to EmployeeList
            EmployeeList.Add(new Employee() { FirstName = "Fred", LastName = "Flinstone", ID = 2 });
            EmployeeList.Add(new Employee() { FirstName = "Barney", LastName = "Rubble", ID = 3 });
            EmployeeList.Add(new Employee() { FirstName = "Jason", LastName = "Bourne", ID = 4 });
            EmployeeList.Add(new Employee() { FirstName = "James", LastName = "Bond", ID = 5 });
            EmployeeList.Add(new Employee() { FirstName = "Joe", LastName = "Greene", ID = 6 });
            EmployeeList.Add(new Employee() { FirstName = "Stephen", LastName = "King", ID = 7 });
            EmployeeList.Add(new Employee() { FirstName = "Jack", LastName = "Ripper", ID = 8 });
            EmployeeList.Add(new Employee() { FirstName = "Jack", LastName = "Ryan", ID = 9 });
            EmployeeList.Add(new Employee() { FirstName = "Joe", LastName = "Average", ID = 10 });
            Console.WriteLine("Press enter to display the employees named \"Joe\" with the for-each loop.");//writes to screen
            Console.ReadLine();                                                                             //wait for user to press enter
            Console.Write("For-each Loop List---");                                                         //write to screen
            Console.WriteLine("\n");                                                                        //new line
        foreach (Employee employee in EmployeeList)
            {               
            if (employee.FirstName == "Joe")
                {               
                Console.WriteLine(employee.LastName + ", " + employee.FirstName);
                }
            }
            Console.WriteLine("\n");                                                                            //new line
            Console.WriteLine("Press enter to display the employees named \"Joe\" with the lambda expression.");//write to screen
            Console.ReadLine();
            Console.WriteLine("\n");                                                                        //new line
            List<Employee> EmployeeList2 = EmployeeList.Where(x => x.FirstName == "Joe").ToList();//lambda expression to parse all "Joe"  
            Console.Write("Lambda List---");                                                                //write to screen
            Console.WriteLine("\n");                                                                            //new line
        foreach (Employee employee in EmployeeList2)                               //start of foreach loop
            {               
                Console.WriteLine(employee.FirstName + " " + employee.LastName);   //write to screen
            } 
            Console.WriteLine("\n");                                                   //new line
            Console.WriteLine("Press enter to display the employees that have an employee ID greater than 5."); //write to screen
            Console.ReadLine();
            List<Employee> EmployeeList3 = EmployeeList.Where(x => x.ID > 5).ToList();
        foreach (Employee employee in EmployeeList3)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + "'s employee ID is " + employee.ID);    //write to screen
            }
            Console.WriteLine("\n");                                                                        //new line
            Console.WriteLine("Press enter to exit...");                                                    //write to screen
            Console.ReadLine();                                                                             //wait for user to press enter
        }        
    }
}
