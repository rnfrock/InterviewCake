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
            int endIdx;
            for( int i = 0; i < l - 1; i++ )
            {
                endIdx = l - (i + 1);

                firstProd *= input[i];
                secondProd *= input[endIdx];

                ans[i+1] = (ans[i+1] == 0) ? firstProd : firstProd * ans[i+1];
                ans[endIdx-1] = (ans[endIdx-1] == 0) ? secondProd : secondProd * ans[endIdx-1];
            }

            return ans;
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 2, 6, 5, 9 };
            int[] ans = getProductsOfAllIntsExceptAtIndex(input);
            foreach( int x in ans )
            {
                Console.Write(x + " ");
            }
        }
    }
}


