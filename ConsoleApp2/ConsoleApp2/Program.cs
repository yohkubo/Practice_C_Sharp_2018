using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P111_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string placeName = "KK party";

            Console.WriteLine("What's your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, {0}!! Welcome to {1}!!", name, placeName);

            Console.WriteLine("Could you tell us your age?:");
            int age;
            bool isInt = int.TryParse(Console.ReadLine(), out age);
            if (!isInt)
            {
                Person person = new Person(name);
            }
            else
            {
                Person person = new Person(name, age);
            }

            if (age > 20) Console.WriteLine("Thank you for joining us!! Let's enjoy the party!!");
            else Console.WriteLine("Sorry, you must be over 20. you can't join the party.");

            Console.ReadLine();

        }
    }

    public class Person
    {
        public Person(string name) : this(name, 0)
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        
    }
}
