﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrillPg124
{
    public class Employee : Person

    {

        public override void SayName()

        {

            base.SayName();         //assigns attributes from Base to SayName

        }

    }
}
