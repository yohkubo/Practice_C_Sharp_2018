﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P047_Exercise_AbstractClass
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName(string lastName, string firstName)
        {
            Console.WriteLine(lastName + ", " + firstName);
        }
    }
}
