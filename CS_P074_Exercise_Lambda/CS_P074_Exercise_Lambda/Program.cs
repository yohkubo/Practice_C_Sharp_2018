using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P074_Exercise_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // P.074 Ex.1
            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee() { Id = 1, FirstName = "Joe", LastName = "Cole" };
            Employee employee2 = new Employee() { Id = 2, FirstName = "Ashley", LastName = "Young" };
            Employee employee3 = new Employee() { Id = 3, FirstName = "Joe", LastName = "Allen" };
            Employee employee4 = new Employee() { Id = 4, FirstName = "Kay", LastName = "Cannon" };
            Employee employee5 = new Employee() { Id = 5, FirstName = "Becky", LastName = "Albertalli" };
            Employee employee6 = new Employee() { Id = 6, FirstName = "Dylan", LastName = "O'Brien" };
            Employee employee7 = new Employee() { Id = 7, FirstName = "Nicolai", LastName = "Fuglsig" };
            Employee employee8 = new Employee() { Id = 8, FirstName = "Jennifer", LastName = "Lawrence" };
            Employee employee9 = new Employee() { Id = 9, FirstName = "Joel", LastName = "Edgerton" };
            Employee employee10 = new Employee() { Id = 10, FirstName = "Charlie", LastName = "Plummer" };
            Employee employee11 = new Employee() { Id = 11, FirstName = "Liam", LastName = "Neeson" };
            Employee employee12 = new Employee() { Id = 12, FirstName = "Dan", LastName = "Stevens" };
            Employee employee13 = new Employee() { Id = 13, FirstName = "Yohei", LastName = "Kubo" };
            Employee employee14 = new Employee() { Id = 14, FirstName = "Joe", LastName = "Russo" };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);
            employees.Add(employee11);
            employees.Add(employee12);
            employees.Add(employee13);
            employees.Add(employee14);

            // P.074 Ex.2
            List<Employee> joeList = new List<Employee>();
            foreach(Employee employee in employees)
            {
               if(employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                } 
            }
            Console.WriteLine("Getting a list of Joe by using foreach loop funcion.");
            foreach(Employee employee in joeList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            
            // P.074 Ex.3
            List<Employee> joeList2 = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("\nGetting the same list by using lambda expression");
            foreach(Employee employee in joeList2)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            // P.074 Ex.4
            List<Employee> lateList = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("\nGetting a list of late employee by using a lambda expression.");
            foreach(Employee employee in lateList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}

