using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P104_Wxercise_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex.1
            Console.WriteLine(DateTime.Now);

            //Ex.2
            Console.Write("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            //Ex.3
            Console.WriteLine(num1 + " hours later from now: " + DateTime.Now.AddHours(num1));
            Console.ReadLine();
        }
    }
}
