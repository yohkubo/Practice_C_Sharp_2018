using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P038_Exercise_Optional_para
{
    class Deal
    {
        public int Sell(int price, int amount = 1)
        {
            int totalPrice = price * amount;
            
            return totalPrice;
        }
    }
}
