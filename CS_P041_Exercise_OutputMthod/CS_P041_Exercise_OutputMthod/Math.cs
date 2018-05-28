using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P041_Exercise_OutputMthod
{
    public static class Math //Exercise 6
    {
        // Exercise 1, 4
        public void Divide(int num1, out int result)
        {
            result = num1 / 2;
        }

        //Eercise 5
        public int Divide(int num1)
        {
            int result = num1 / 2;
            return result;
        }

        public void Divide(string data1)
        {
            Console.WriteLine("You entered '" + data1 + "', not a whole number.");
        }
    }
}
