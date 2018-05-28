using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P043_Exercise_Inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string fullName = LastName + ", " + FirstName;
            Console.WriteLine("Name: " + fullName);
        }
    }
}
