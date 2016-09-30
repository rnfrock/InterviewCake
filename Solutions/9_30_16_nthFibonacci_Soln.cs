// 9/30/2016 nth Fibonacci Interview Question

using System;

namespace _9_30_16_nthFibonacci_Soln
{
    class Solution
    {

        public static int fib( int n )
        {
            if( n == 0 || n == 1 )
            {
                return n;
            } else
            {
                return fib(n-1) + fib(n-2);
            }
        }

        static void Main(string[] args)
        {
            int n = 8;
            Console.WriteLine("Given " + n + " fib() returns " + fib(n));
        }
    }
}
