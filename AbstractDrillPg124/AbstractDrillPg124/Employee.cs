using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrillPg126
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()                  //overrides rules to allow to inherit SayName
        {
            base.SayName();                             //inherit Base to SayName
        }
        public void Quit()
        {
            throw new NotImplementedException();          //Exception for error
        }
    }
}
