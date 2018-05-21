using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P021_Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is a temperature in your room?");
            int roomTemperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is current temperature outside?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if(currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly same as room temperature.");
            //}
            //else if(currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if(roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Your room is warmer than outside.");
            //}
            //else
            //{
            //    Console.WriteLine("Something is wrong you input.");
            //}

            //terner operator
            string comparisonTemperature = roomTemperature == currentTemperature ?
                "It is room temp." : "It is not room temp.";
            Console.WriteLine(comparisonTemperature);

            Console.ReadLine();

        }
    }
}
