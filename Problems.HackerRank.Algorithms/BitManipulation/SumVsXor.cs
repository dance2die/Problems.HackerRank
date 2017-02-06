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
INPUT: 1099511627776 OUTPUT: 1099511627776
 */

            long result = GetEqualSumAndXorCount2(number);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Cheated from discussion
        /// </summary>
        private static long GetEqualSumAndXorCount2(long number)
        {
            Func<long, string> toBin = v => Convert.ToString(v, 2);

            int count = 0;
            while (number > 0)
            {
                //Console.WriteLine("{0}({1}) & 1 = {2}({3})", number, toBin(number), number & 1, toBin(number & 1));
                if ((number & 1) == 0)
                    count++;

                number >>= 1;
            }

            return 1L << count;
        }

        private static int GetEqualSumAndXorCount(long number)
        {
            int count = 0;
            Func<long, string> toBin = v => Convert.ToString(v, 2);

            for (int i = 0; i <= number; i++)
            {
                var mask = 1 << i;
                long sum = number + i;
                long xor = number ^ i;

                if (sum == xor)
                {
                    Console.Write("{0}({1}) + {2}({3}) = {4}({5}) <=> ", number, toBin(number), mask, toBin(i), sum, toBin(i));
                    Console.WriteLine("{0}({1}) ^ {2}({3}) = {4}({5})", number, toBin(number), mask, toBin(i), xor, toBin(i));

                    count++;
                }
            }

            return count;
        }
    }
}
