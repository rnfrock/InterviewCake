// 10/5/2016 Stolen Drone Interview Question

using System;
using System.Collections.Generic;



namespace _10_5_16_StolenDrone_Soln
{
    class Program
    {
        public static int findUniqueID(int[] array)
        {
            List<int> missing = new List<int>();
            int current = -1;
            for (int i = 0; i < array.Length; i++)
            {
                current = array[i];
                if (missing.Contains(current))
                {
                    missing.Remove(current);
                }
                else
                {
                    missing.Add(current);
                }

            }
            int[] id = missing.ToArray();
            return id[0];
        }

        static void Main(string[] args)
        {
            int[] deliveryIDConfirmations = { 1, 2, 2, 3, 4, 3, 4, 5, 5 };
            // int[] deliveryIDConfirmations = { 1, 2, 3, 4, 5, 1, 2, 3, 4 };
            Console.WriteLine("The missing drone is " + findUniqueID(deliveryIDConfirmations));
        }
    }
}
