using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P041_Exercise_OutputMthod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); // Exercise 2
            Console.WriteLine("Enter a whole number: "); // Exercise 3
            string input1 = Console.ReadLine();
            int num = 0;
            int result = 0;

            bool isInt = int.TryParse(input1, out num);
            if (!isInt)
            {
                math.Divide(input1);
            }
            else if (isInt)
            {
                //Console.WriteLine("Using retuning int 'Divide' method: " + math.Divide(num));

                math.Divide(num, out result);
                Console.WriteLine("Using void 'Divide' method: " + result);
            }
            else
            {
                Console.WriteLine("Something is wrong.");
            }

            Console.ReadLine();
        }
    }
}
