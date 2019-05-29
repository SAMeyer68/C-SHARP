using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethodDrill114
{
    class Math
    {
        public int SameName(int num1)
        {
            int total1 = num1 - 1;
            return total1;
        }

        public int SameName(double number)
        {
            double result = number * 10.5;
            int total2 = Convert.ToInt32(result);
            return total2;
        }

        public int SameName(string a)
        {
            int numA = Convert.ToInt32(a);
            int total3 = numA + 1;
            return total3;
        }
    }
}
