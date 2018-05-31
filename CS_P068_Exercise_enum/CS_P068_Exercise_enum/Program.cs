using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P068_Exercise_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What a day is it today? Enter a day of the week:");
            try
            {
                string day = Console.ReadLine();

                DaysOfTheWeek theDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);

                Console.WriteLine("Today is: " + theDay);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
