﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrillPg126
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine("Employee: " + FirstName + " " + LastName);   //write to screen
        }
    }
}
