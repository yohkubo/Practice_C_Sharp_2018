using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P028_Exercise_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            string[] stringArray = new string[5];
            stringArray[0] = "Toshihiro";
            stringArray[1] = "Matchiko";
            stringArray[2] = "Ryusuke";
            stringArray[3] = "Mana";
            stringArray[4] = "Kensuke";


            Console.WriteLine("Put an index number between 0 and 4:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            while(num1 < 0 || num1 > stringArray.GetUpperBound(0)) // Exercise 3
            {
                Console.WriteLine("The index you input was wrong. Put an index between 0 and 4:");
                num1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(stringArray[num1] + ". It is my family.");
            Console.ReadLine();

            
            //Exercise 2
            int[] integersArray = new int[] { 1, 5, 12, 76, 78 };

            Console.WriteLine("Put an index number between 0 and 4:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            while (num2 < 0 || num2 > integersArray.GetUpperBound(0)) // Exercise 3
            {
                Console.WriteLine("The index you input was wrong. Put an index between 0 and 4:");
                num2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The number you chose has: " + integersArray[num2]);
            Console.ReadLine();

            
            //Exercise 4
            List<string> list = new List<string>();
            list.Add("Hello!");
            list.Add("Good morning!");
            list.Add("Good evening!");
            list.Add("What's up!");
            list.Add("Dude!");

            Console.WriteLine("Put an index number between 0 and 4:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            while(num4<0 || num4>list.Count - 1)
            {
                Console.WriteLine("The index you input was wrong. Put an index between 0 and 4:");
                num4 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The word you chose is: " + list[num4]);
            Console.ReadLine();

        }
    }
}
