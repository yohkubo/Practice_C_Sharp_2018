using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P071_Exercise_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 12;
            //int num2 = num1;
            //num2 = 11;
            //Console.WriteLine(num1+ "\n" +num2);

            Number number1 = new Number();
            number1.Amount = 123.2m;

            Number number2 = number1;
            number2.Amount = 999.9m;

            Console.WriteLine("Number1: " + number1.Amount + "\nNumber2: " + number2.Amount);

            Console.ReadLine();
        }
    }
    public struct Number
    {
        public decimal Amount { get; set; }
    } 

}
