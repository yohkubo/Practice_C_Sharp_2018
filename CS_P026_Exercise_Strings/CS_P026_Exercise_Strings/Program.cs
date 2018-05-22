using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P026_Exercise_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name by separating first name, middle name, and last name.\nFirst name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Middle name:");
            string middleName = Console.ReadLine();
            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();
            
            string fullName = firstName + " " + middleName + " " + lastName;

            Console.WriteLine(fullName);
            Console.WriteLine(fullName.ToUpper());

            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("Hi, I am joining this program from Japan at the morment.");
            sb.Append("I am studing hard lately and I have to finish this within 4 weeks.\n");
            sb.Append("After this program, I hope I will become a web developer and go to the USA for work.");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
