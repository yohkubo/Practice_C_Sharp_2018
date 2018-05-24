using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P035_Exercise_Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers.\nFirst one:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second one:");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Addition addition = new Addition();
            int resultAdd = addition.Add(numOne, numTwo);

            Subtraction subtraction = new Subtraction();
            int resultSub = subtraction.Sub(numOne, numTwo);

            Division division = new Division();
            int resultDiv = division.Div(numOne, numTwo);

            Console.WriteLine("Adds first number to second one: " + resultAdd + 
                "\nSubtracts second number from first one: " + resultSub +
                "\nDivides second number from first one: "+ resultDiv);
            Console.ReadLine();

        }
    }
}
