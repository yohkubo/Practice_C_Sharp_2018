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

            //IQuittable quittable = new Employee() { firstName = "Sample", lastName = "Employee" };
            //quittable.Quit();

            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee() { firstName = "Yohei", lastName = "Kubo", EmployeeId = 0 };
            Employee employee2 = new Employee() { firstName = "Kensuke", lastName = "Kubo", EmployeeId = 1 };
            Employee employee3 = new Employee() { firstName = "Ryusuke", lastName = "Kubo", EmployeeId = 0 };

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee2 == employee3);
            Console.WriteLine(employee3 == employee1);

            Console.ReadLine();
        }
    }
}
