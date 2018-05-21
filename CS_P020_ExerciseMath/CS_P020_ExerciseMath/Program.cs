using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P020_ExerciseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1-1
            int mulNum = 50;
            Console.WriteLine("1-1. Input a number which is gonna be multiplied by " + mulNum + ": ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = num1 * mulNum;
            Console.WriteLine("Result1 is: " + result1);
            Console.ReadLine();

            // Exercise 1-2
            int addNum = 25;
            Console.WriteLine("1-2. Input a number which is gonna be added to " + addNum + ":");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result2 = num2 + addNum;
            Console.WriteLine("Result2 is: " + result2);
            Console.ReadLine();

            //Exercise 1-3
            double divNum = 12.5;
            Console.WriteLine("1-3. Input a number which is gonna be divided by 12.5: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double result3 = num3 / divNum;
            Console.WriteLine("Result3 is: " + result3);
            Console.ReadLine();

            //Exercise 1-4
            int comparisonNum = 50;
            Console.WriteLine("1-4. Input a number, then it's gonna be checked if it's greater than 50:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool result4 = num4 > comparisonNum;
            Console.WriteLine("Result4 is: " + result4);
            Console.ReadLine();

            //Exercise 1-5
            int remNum = 7;
            Console.WriteLine("1-5. Input a number which is gonna be divided by " + remNum +
                ", and print the remainder:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int result5 = num5 % remNum;
            Console.WriteLine("Result5 is: " + result5);
            Console.ReadLine();


            //Exercise 2-1
            bool eva1 = 3 > 2 && 5 > 4;
            Console.WriteLine("2-1. Result is: " + eva1);
            Console.ReadLine();

            //Exercise 2-2
            bool eva2 = 3 > 2 || 5 > 4;
            Console.WriteLine("2-2. Result is: " + eva2);
            Console.ReadLine();

            //Exercise 2-3
            bool eva3 = 2 + 2 != 4;
            Console.WriteLine("2-3. Result is: " + eva3);
            Console.ReadLine();

        }
    }
}
