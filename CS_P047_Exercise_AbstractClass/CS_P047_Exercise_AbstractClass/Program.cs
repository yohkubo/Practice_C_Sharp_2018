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
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.firstName = "Yohei";
            employee.lastName = "Kubo";
            employee.Things.Add("Laptop");
            employee.Things.Add("Cell Phone");
            employee.Things.Add("Car");

            Employee<int> employee1 = new Employee<int>() { firstName = "Kensuke", lastName = "Kubo" };
            employee1.Things = new List<int>();
            employee1.Things.Add(8);
            employee1.Things.Add(12);
            employee1.Things.Add(1300);

            Console.WriteLine("Name: {0} {1}", employee.firstName, employee.lastName);
            foreach(string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("Name: {0} {1}", employee1.firstName, employee1.lastName);
            foreach(int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }


            //Person person = new Employee() { firstName = "Sample", lastName = "Student" };
            //person.SayName(person.lastName, person.firstName);
            //IQuittable quittable = new Employee() { firstName = "Sample", lastName = "Employee" };
            //quittable.Quit();

            //Employee<string> employee1 = new Employee<string>() { firstName = "Yohei", lastName = "Kubo", EmployeeId = 0 };
            //Employee<string> employee2 = new Employee<string>() { firstName = "Kensuke", lastName = "Kubo", EmployeeId = 1 };
            //Employee<string> employee3 = new Employee<string>() { firstName = "Ryusuke", lastName = "Kubo", EmployeeId = 0 };

            //Console.WriteLine(employee1 == employee2);
            //Console.WriteLine(employee2 == employee3);
            //Console.WriteLine(employee3 == employee1);

            Console.ReadLine();
        }
    }
}
