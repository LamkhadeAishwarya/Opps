using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Ass
    {
        
        static float Selling(int cost_price, int Total_Items, int profit)
        {
           float price = (float)(cost_price + (cost_price * profit));
            return price;
        }
        static void Main(string[] args)
        {

        }
    }
}
