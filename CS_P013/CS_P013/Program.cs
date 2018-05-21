using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much is that you just bought?");
            int price = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your deal costs " + CalculateTotalPrice(price));
            Console.ReadLine();
            
        int CalculateTotalPrice(int productPrice, int shippingPrice = 3)
        {
            return productPrice + shippingPrice;
        }
            
        }


        
    }
}
