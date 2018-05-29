using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P047_Exercise_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Employee() { firstName = "Sample", lastName = "Student" };
            //person.SayName(person.lastName, person.firstName);

            IQuittable quittable = new Employee() { firstName = "Sample", lastName = "Employee" };
            
            quittable.Quit();
            
            Console.ReadLine();
        }
    }
}
