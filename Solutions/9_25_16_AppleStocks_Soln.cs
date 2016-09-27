// 9/25/2016 Apple Stocks Interview Question


using System;

namespace _9_25_16_AppleStock_Soln
{
    class Solution
    {

        public static string get_max_profit(int[] arg)
        {
            // write the body of your function here
            int bestBuy = arg[0];
            int buyIdx = 0;
            int bestSell = arg[0];
            int sellIdx = 0;

            for( int i = 2; i < arg.Length; i++ )
            {
                if( arg[i] < bestBuy )
                {
                    buyIdx = i;
                    bestBuy = arg[i];
                }
                if( sellIdx < buyIdx || (i > buyIdx && arg[i] > bestSell) )   
                {
                    sellIdx = i;
                    bestSell = arg[i];
                }
                // need case if the rest are just a decline...
                // need best negative case
            }
            return "running with " + bestBuy + ", " + bestSell;
        }


        static void Main(string[] args)
        {
            // run your function through some test cases here
            // remember: debugging is half the battle!
            int[] stock_prices_yesterday = { 10, 7, 5, 8, 11, 9 };
            Console.WriteLine(get_max_profit(stock_prices_yesterday));
        }
    }
}
