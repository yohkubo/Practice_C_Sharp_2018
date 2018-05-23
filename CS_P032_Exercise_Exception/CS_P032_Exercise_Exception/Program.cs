using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P032_Exercise_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Exercise 5
            try
            {
                List<int> nums = new List<int>() { 5, 13, 45, 43, 444, 5678, 432, 46, 3, 94 };
                Console.WriteLine("There is a list of numbers. Enter a number to devide numbers in the list.");
                int divNum = Convert.ToInt32(Console.ReadLine());

                foreach(int num in nums)
                {
                    int result = num / divNum;
                    Console.WriteLine("Divided " + num + " by " + divNum + " is: " + result);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }

            
            ////Exercise 3 error for dividing by zero
            //"System.DivideByZeroException: 'Attempted to divide by zero.'"

            ////Exercise 4 error for entring string data to int data variable
            //"System.FormatException: 'Input string was not in a correct format.'"


        }
    }
}
