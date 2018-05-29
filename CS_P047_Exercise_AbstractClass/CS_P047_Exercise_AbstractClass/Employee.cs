using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P047_Exercise_AbstractClass
{
    class Employee : Person, IQuittable
    {
        public int EmployeeId { get; set; }
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

        // operator== 
        public static bool operator== (Employee emp1, Employee emp2)
        {
            return (emp1.EmployeeId == emp2.EmployeeId);
        } 
        public static bool operator!=(Employee emp1, Employee emp2)
        {
            Console.WriteLine(emp1.firstName + "'ID and " + emp2.firstName + "'s ID are different. No problem.");

            return (emp1.EmployeeId != emp2.EmployeeId);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
