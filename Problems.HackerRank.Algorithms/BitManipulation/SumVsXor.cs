using System;

namespace Problems.HackerRank.Algorithms.BitManipulation
{
    /// <summary>
    /// Sum vs XOR
    /// https://www.hackerrank.com/challenges/sum-vs-xor
    /// </summary>
    public class SumVsXor
    {
        public static void Main(string[] args)
        {
            long number = Convert.ToInt64(Console.ReadLine());
/*
INPUT: 5 OUTPUT: 2
INPUT: 10 OUTPUT: 4

 */

            int result = GetEqualSumAndXorCount(number);
            Console.WriteLine(result);
        }

        private static int GetEqualSumAndXorCount(long number)
        {
            int count = 0;
            int mask = 1;
            for (int i = 0; i <= number; i++)
            {
                mask = 1 << i;
                long sum = number + i;
                long xor = number ^ i;
                if (sum == xor)
                    count++;
            }

            return count;
        }
    }
}
