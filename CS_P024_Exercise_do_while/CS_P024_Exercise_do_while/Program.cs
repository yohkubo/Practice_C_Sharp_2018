using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P024_Exercise_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 1
            //Console.WriteLine("Guess my foot size? Answer with a whole number:");
            //int num = Convert.ToInt16(Console.ReadLine());
            //bool isMine = false;

            //while (!isMine)
            //{
            //    switch (num)
            //    {
            //        case 7:
            //            Console.WriteLine("7 is not same as mine. Answer it again.");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 8:
            //            Console.WriteLine("8 is not same as mine. Answer it again.");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 9:
            //            Console.WriteLine("9 is my size! Congrats!!");
            //            isMine = true;
            //            break;

            //        case 10:
            //            Console.WriteLine("10 is not same as mine. Answer it again.");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 11:
            //            Console.WriteLine("11 is not same as mine. Answer it again.");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 12:
            //            Console.WriteLine("12 is not same as mine. Answer it again.");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        default:
            //            Console.WriteLine("Too far from my size!! Guess my size and answer it.");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            //Console.ReadLine();

            //Exercise 2
            Console.WriteLine("Guess my foot size? Answer with a whole number:"); //My size is 9
            int num = Convert.ToInt16(Console.ReadLine());
            bool isMine = num == 9;

            do
            {
                switch (num)
                {
                    case 7:
                        Console.WriteLine("7 is not same as mine. Answer it again.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("8 is not same as mine. Answer it again.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("9 is my size! Congrats!!");
                        isMine = true;
                        break;

                    case 10:
                        Console.WriteLine("10 is not same as mine. Answer it again.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 11:
                        Console.WriteLine("11 is not same as mine. Answer it again.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("12 is not same as mine. Answer it again.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Too far from my size!! Guess my size and answer it.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } while (!isMine);

            Console.ReadLine();

        }
    }
}
