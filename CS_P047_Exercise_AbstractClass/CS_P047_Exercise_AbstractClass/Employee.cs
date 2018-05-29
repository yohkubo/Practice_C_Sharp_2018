using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P047_Exercise_AbstractClass
{
    // P.54 Ex.1
    class Employee<T> : Person, IQuittable
    {
        public List<T> Things = new List<T>(); // P.54 Ex.2
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
        public static bool operator== (Employee<T> emp1, Employee<T> emp2)
        {
            return (emp1.EmployeeId == emp2.EmployeeId);
        } 
        public static bool operator!=(Employee<T> emp1, Employee<T> emp2)
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
