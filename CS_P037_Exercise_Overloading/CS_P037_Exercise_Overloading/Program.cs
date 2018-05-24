using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P037_Exercise_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int num1 = 2;
            decimal num2 = 999.99m;
            string num3 = "3";

            Console.WriteLine("A slise of the pizza is for 3 bucks. If you want " + num1 + 
                " slices, It is going to be: USD" + math.Multi(num1));
            Console.WriteLine("The price of iPhone X is " + num2 + 
                ". If it exchanges to Japanese Yen: JPY" + math.Multi(num2));
            Console.WriteLine(num3 + "pounds is: " + math.Multi(num3) + "g");

            Console.ReadLine();
        }
        class Math
        {
            public int Multi(int num)
            {
                int result = 3 * num;
                return result;
            }

            public int Multi(decimal num)
            {
                int result = Convert.ToInt32(num * 109.17m);
                return result;
            }
            public int Multi(string num)
            {
                int result = Convert.ToInt32(num) * 450;
                return result;
            }

        }
    }
}
