using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrillPage131
{
    public class Employee<T> : Person, IQuittable

    {

        //GENERIC EXAMPLE

        public List<T> Things { get; set; }
     
        //PERSON CLASS

        public override void SayName()
        {
            base.SayName();
        }

        //IQUITTABLE INTERFACE

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
