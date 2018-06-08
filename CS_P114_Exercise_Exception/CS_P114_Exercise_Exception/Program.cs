using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P114_Exercise_Exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age.");

            try
            {
                int age;
                bool validAnswer = false;

                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer) throw new Exception();

                else if (age < 1) throw new NegativeException();
                
                DateTime born = DateTime.Now;
                Console.WriteLine(born.AddYears(-age).Year);
                Console.ReadLine();
                
            }
            catch (NegativeException)
            {
                Console.WriteLine("Please enter a digit number over 0. It can not be zero or negative.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("You entered something wrong. Please enter digits.");
                Console.ReadLine();
            }    
        }

        public class NegativeException : Exception
        {
            public NegativeException()
                : base() { }
        }
    }
}
