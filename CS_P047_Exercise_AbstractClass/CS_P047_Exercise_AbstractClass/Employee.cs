using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P047_Exercise_AbstractClass
{
    class Employee : Person, IQuittable
    {

        public bool isActiveEmployee { get; set; }

        public override void SayName(string lastName, string firstName)
        {
            Console.Write("Employee's name: ");
            base.SayName(lastName, firstName);
        }
        public void Quit()
        {
            Console.WriteLine("Quittable.");
        }
    }
}
