using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrillPg126
{
    public abstract class Person
    {
        public string FirstName { get; set; }                               //Gets and sets FirstName
        public string LastName { get; set; }                                //Gets and sets LastName
        public virtual void SayName()                                       //Calls SayName and allows changes to be made
        {
            Console.WriteLine("Employee: " + FirstName + " " + LastName);   //write to screen
        }
    }
}
