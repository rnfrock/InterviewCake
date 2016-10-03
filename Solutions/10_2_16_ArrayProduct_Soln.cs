// 10_2_16_ArrayProduct Solution


using System;

namespace _10_2_16_ArrayProduct_Soln
{
    class Solution
    {
        public static int[] getProductsOfAllIntsExceptAtIndex( int[] input )
        {
            int l = input.Length;
            int[] ans = new int[ l ];          
            int firstProd = 1;
            int secondProd = 1;
            for( int i = 0; i < l - 1; i++ )
            {
                int endIdx = l - (i + 1);
                firstProd *= input[i];
                secondProd *= input[endIdx];
                //Console.WriteLine("firstProd = " + firstProd + ", secondProd = " + secondProd + ", i = " + i);       
                if( i < ((l * 0.5)-1) || i == l-2 ) {
                    ans[i+1] = firstProd;
                    ans[endIdx-1] = secondProd;
                }else {
                    ans[i+1] *= firstProd;
                    ans[endIdx-1] *= secondProd;
                }
            }
            return ans;
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 7, 3, 4 };
            foreach( int x in getProductsOfAllIntsExceptAtIndex(input) )
            {
                Console.Write(x + " ");
            }
        }
    }
}
