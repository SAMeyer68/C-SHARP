using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodDrill114
{
    class Math                                                  //defines class name to Math
    {
        public int SameName(int num1)                           //takes integer 12 assigns to num1, since int, then run
        {
            int total1 = num1 - 1;                              //takes 12-1 and assigns result to total1
            return total1;                                      //resturns total1 
        }

        public int SameName(double number)                      //takes double number 5.5 assigns to number, since a double, then run
        {
            double result = number * 10.5;                      //take 5.5 * 10.5 and assigns result to result
            int total2 = Convert.ToInt32(result);               //convert result to ToInt32 and assigns to total2
            return total2;                                      //resturns total2 
        }

        public int SameName(string a)                           //takes string "25" assigns to a, since a string then run
        {
            int numA = Convert.ToInt32(a);                      //converts a to int and assigns to numA
            int total3 = numA + 1;                              //adds numA +1 and assigns result to total3
            return total3;                                      //resturns total3
        }
    }
}
