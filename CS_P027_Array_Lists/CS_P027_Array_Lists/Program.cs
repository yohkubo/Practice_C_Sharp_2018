using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P027_Array_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray1 = new int[5];
            numArray1[0] = 5;
            numArray1[1] = 2;
            numArray1[2] = 10;
            numArray1[3] = 200;
            numArray1[4] = 5000;

            int[] numArray2 = new int[] { 1, 22, 300, -4, 512};
            int[] numArray3 = { 3, 23, 34, 50, 62 };

            //Console.WriteLine(numArray1[4]);
            //Console.WriteLine(numArray2[3]);
            //Console.WriteLine(numArray3[4]);

            //numArray3[4] = 90000;
            //Console.WriteLine(numArray3[4]);

            List<int> intList = new List<int>();
            intList.Add(12);
            intList.Add(500);
            intList.Add(12012);

            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("Jesse");
            stringList.Add("get on!!");

            //Console.WriteLine(stringList[0] + " " + intList[2]);

            byte[] byteArray = { 100, 123 };

            Console.ReadLine();


        }
    }
}
