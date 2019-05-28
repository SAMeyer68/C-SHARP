using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathMethod
{
    class Math
    {
        public double Number { get; set; } //makes public, gets returned number and assigns value number
        public double Add(double number)   //assigns number to Add
        {
            return number + 100;           //takes number, adds 100 and returns as number
        }
        public double triple(double number)//assigns number to triple
        {
            return number * 3;             //takes number, multiplies it by 3 and returns as number
        }
        public double byTwo(double number) //assigns number to byTwo
        {
            return number / 2;             //takes number, divided by 2 and returns as number
        }
    }
}
