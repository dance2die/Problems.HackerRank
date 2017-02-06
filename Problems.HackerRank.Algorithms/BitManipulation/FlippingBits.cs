using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.BitManipulation
{
    /// <summary>
    /// Flipping Bits
    /// https://www.hackerrank.com/challenges/flipping-bits
    /// </summary>
    public class FlippingBits
    {
        public static void Main(String[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = GetNumbers(arraySize).ToList();

/*
INPUT:
3 
2147483647 
1 
0
OUTPUT:
2147483648 
4294967294 
4294967295
*/
        }

        private static IEnumerable<int> GetNumbers(int arraySize)
        {
            for (int i = 0; i < arraySize; i++)
            {
                yield return Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
