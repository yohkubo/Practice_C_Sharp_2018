using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P022_Exercise_Compariseon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight?");
            int currentWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What was your weight 5 years ago?");
            int oldWeight = Convert.ToInt32(Console.ReadLine());

            //Exercise 1, 2
            if (currentWeight == oldWeight)
            {
                Console.WriteLine("Your current weight is exact same as five years ago.");
            }
            else if (currentWeight > oldWeight)
            {
                Console.WriteLine("Your current weight is heavier than five years ago.");
            }
            else if (currentWeight < oldWeight)
            {
                Console.WriteLine("Your current weight is lighter than fice years ago.");
            }
            else
            {
                Console.WriteLine("Something is wrong.");
            }

            Console.ReadLine();

            //Exersice 3
            string comparisonWeight = currentWeight == oldWeight ?
                "Your current weight is same as five years ago." : "Your current weight is not same as five years ago.";
            Console.WriteLine(comparisonWeight);

            Console.ReadLine();

        }
    }
}
