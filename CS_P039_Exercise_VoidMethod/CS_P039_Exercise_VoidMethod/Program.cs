using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P039_Exercise_VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Enter 2 numbers.\nFirst:");
            bool isNum1 = int.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Second:");
            bool isNum2 = int.TryParse(Console.ReadLine(), out num2);

            if (!isNum1 || !isNum2)
            {
                Console.WriteLine("You entered something wrong. Enter 2 whole numbers.");
            }
            else
            {
              Math math = new Math();
                math.TestMath(num1, num2);
            }

            Console.ReadLine();
        }
    }

    public class Math
    {
        public void TestMath(int num1, int num2)
        {
            int result1 = num1 * 5;
            Console.WriteLine("You entered " + num1 + " to first number. Multiplied it to 5 is: " + result1 +
                "\nSecond number you entered is: " + num2);
        }

    }
}
