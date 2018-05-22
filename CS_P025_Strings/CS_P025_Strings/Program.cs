using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P025_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string quote = "The man is \"flash\". \nI am studing at home today.\n\tYou gotta come here.";
            string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("e");
            //trueOrFalse = name.EndsWith("k");
            //Console.WriteLine(trueOrFalse);
            //int nameLength = name.Length;
            //Console.WriteLine(nameLength);

            //name = name.ToUpper();
            ////Console.WriteLine("Hello, " + name + ". " + quote);
            //Console.WriteLine(name);
            //name = name.ToLower();
            //Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();

            sb.Append("Jesse\n");
            sb.Append("Yohei");

            Console.WriteLine(sb);

            Console.ReadLine();
        }

    }
}
