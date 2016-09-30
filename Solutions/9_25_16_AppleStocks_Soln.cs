// 9/25/2016 Apple Stocks Interview Question


using System;

namespace _9_25_16_AppleStock_Soln
{
    class Solution
    {

        public static int get_max_profit(int[] arg)
        {
            // write the body of your function here
            int bestBuy = arg[0];
            int buyIdx = 0;
            int bestSell = arg[1];
            int sellIdx = 1;
            int totalProfit = bestSell - bestBuy;

            for( int i = 0; i < arg.Length - 1; i++ )
            {
                if( arg[i + 1] - arg[i] > totalProfit )
                {
                    totalProfit = arg[i + 1] - arg[i];
                }
                if( arg[i] < bestBuy )
                {
                    buyIdx = i;
                    bestBuy = arg[i];
                }
                if( buyIdx > sellIdx || arg[i + 1] < bestSell )
                {
                    sellIdx = i + 1;
                    bestSell = arg[i + 1];
                } 
                
            }
            return ( (bestSell - bestBuy) > totalProfit ) ? (bestSell - bestBuy) : totalProfit;
        }


        static void Main(string[] args)
        {
            // run your function through some test cases here
            // remember: debugging is half the battle!
            //int[] stock_prices_yesterday = { 10, 7, 5, 8, 11, 9 };
            int[] stock_prices_yesterday = { 10, 8, 7, 4, 2, 0 };
            Console.WriteLine("Max profit is " + get_max_profit(stock_prices_yesterday));
        }
    }
}
