using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_P099_Exercese_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex.1
            Console.Write("Enter a number: ");
            string text1 = Console.ReadLine();
            text1 = string.Format(text1).ToString();

            // Ex.2
            using(StreamWriter file = new StreamWriter(@"C:\Users\windows7\Documents\Logs\log2.txt", true))
            {
                file.WriteLine(text1);
            }

            // Storing each line in the file to string array
            string[] texts = File.ReadAllLines(@"C:\Users\windows7\Documents\Logs\log2.txt");
            Console.WriteLine("Numbers you entered to Log2.txt file" + "/n");
            
            //Ex.3
            // Write each line in texts array to console window
            foreach(string line in texts)
            {
                Console.WriteLine("\t" + line);
            }
            Console.ReadLine();
        }
    }
}
