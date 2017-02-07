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
            List<uint> numbers = GetNumbers(arraySize).ToList();

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

            var output = GetFlippedNumbers(numbers);
            PrintUnsignedNumbers(output);
        }

        private static IEnumerable<uint> GetFlippedNumbers(List<uint> numbers)
        {
            foreach (uint number in numbers)
            {
                yield return ~number;
            }
        }

        private static void PrintUnsignedNumbers(IEnumerable<uint> output)
        {
            foreach (var number in output)
            {
                Console.WriteLine(number);
            }
        }

        private static IEnumerable<uint> GetNumbers(int arraySize)
        {
            for (int i = 0; i < arraySize; i++)
            {
                yield return Convert.ToUInt32(Console.ReadLine());
            }
        }
    }
}
