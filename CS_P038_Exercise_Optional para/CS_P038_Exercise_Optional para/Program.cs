using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P038_Exercise_Optional_para
{
    class Program
    {
        static void Main(string[] args)
        {
            Deal deal = new Deal();
            int bill = 0;
            
            Console.WriteLine("Enter two numbers. First number is a price of what you purchace. Second number is amount." +
                "Secound one is not necessary if you purchase just one.\nFist number:");
            string numOne = Console.ReadLine();
            
            Console.WriteLine("Second number:");
            string numTwo = Console.ReadLine();

            if(numOne == string.Empty)
            {
                Console.WriteLine("You did not enter to first one. You must do it.");
            }
            else if (numTwo == string.Empty)
            {
                bill = deal.Sell(Convert.ToInt32(numOne));
                Console.WriteLine("Purchasing the item priced at " + numOne + ". Total price of your shopping is:" + bill);
            }
            else
            {
                bill = deal.Sell(Convert.ToInt32(numOne), Convert.ToInt32(numTwo));
                Console.WriteLine("Purchasing "+ numTwo +" of the item priced at " + numTwo + ". Total price of your shopping is:" + bill);
            
            }
            Console.ReadLine();
        }
    }
}
