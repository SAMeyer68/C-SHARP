using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstChainDrillPage162
{
    public class Class1
    {
        public Class1(string Tuckers) : this(50, Tuckers)             //Puts the two strings together
        {
        }
        public Class1(int car, string name)
        {
            Cars = car;
            TucksCars = name;
        }
        public int Cars { get; set; }
        public string TucksCars { get; set; }
    }
}
