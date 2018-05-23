using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P030_Exercise_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 1
            //string[] names = { "Toshihiro", "Machiko", "Ryusuke", "Mana", "Kensuke", "Hiroko", "Yuga", "Sota", "Yohei" };

            //Console.WriteLine("Type something greeting:");
            //string word = Console.ReadLine();
            //foreach (string name in names)
            //{
            //    Console.WriteLine(word + ", " + name);
            //}
            //Console.ReadLine();

            ////Exercise 2
            //int[] nums = { 23, 43, 44, 67, 5, 98, 100 };
            //int sum2 = 0;

            //while (sum2>=0)
            //{
            //    sum2= sum2 + 4;
            //    Console.WriteLine(sum2);
            //}
            //Console.ReadLine();

            ////Exercise 3_Fixing Exe.1
            ////Exercise 4
            //int sum3 = 0;

            //while (sum3 < 100)
            //{
            //    sum3 = sum3 + 4;
            //    Console.WriteLine(sum3);
            //}
            //Console.ReadLine();


            ////Exercise 5
            //int sum5 = 0;

            //while (sum5 <= 100)
            //{
            //    sum5 = sum5 + 4;
            //    Console.WriteLine(sum5);
            //}
            //Console.ReadLine();


            ////Exercise 6
            //List<string> names = new List<string>() { "Toshihiro", "Machiko", "Ryusuke", "Mana", "Kensuke", "Yohei" };
            //Console.WriteLine("Type a name of my family. If you do not know any, guess it:");
            //string inputName = Console.ReadLine();
            //bool isCorrect = false;

            //for(int i = 0; i < names.Count; i++)
            //{
            //    if(names[i] == inputName)
            //    {
            //        Console.WriteLine("The index of the name on the list is:" + i);
            //        isCorrect = true;
            //        break; // For Exercise 8
            //    }
            //}

            //if (!isCorrect) // For Exercise 7
            //{
            //    Console.WriteLine("The name you typed is not in the list.");
            //}

            //Console.ReadLine();


            ////Exercise 9
            //List<string> names9 = new List<string>
            //{ "Toshihiro", "Machiko", "Ryusuke", "Mana", "Kensuke", "Yohei", "Machiko",
            //    "Kensuke", "Machiko", "Mana" };
            //Console.WriteLine("Type a name of my family. If you do not know any of them, guess it:");
            //string inputName9 = Console.ReadLine();
            //bool isCorrect = false;
            
            //for(int i =0; i<names9.Count; i++)
            //{
            //    if (names9[i] == inputName9)
            //    {
            //        Console.WriteLine("The index of the name on the list is:" + i);
            //        isCorrect = true;
            //    }
            //}

            //if (!isCorrect) // For Exercise 10
            //{
            //    Console.WriteLine("The name you typed is not in the list");
            //}

            //Console.ReadLine();


            //Exercise 11
            List<string> names11 = new List<string>() {"Toshihiro", "Machiko", "Machiko", "Kensuke", "Machiko", "Mana", "Ryusuke", "Mana", "Kensuke", "Yohei" };

            List<string> prename11 = new List<string>(); // A list which stores names already appeared
            
            foreach(string name in names11)
            {
                Console.Write(name);

                foreach (string prename in prename11)
                {
                    if(prename == name)
                    {
                        Console.Write("(already appeared)");
                        break;
                    }
                }
                Console.WriteLine("");
                prename11.Add(name);
            }
            Console.ReadLine();

        }
    }
}
