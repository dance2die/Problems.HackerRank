using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Divisible Sum Pairs
    /// https://www.hackerrank.com/challenges/divisible-sum-pairs
    /// </summary>
    public class DivisibleSumPairs
    {
        public static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);

            /*
Input:
6 3
1 3 2 6 1 2
Output:
5
             */

            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if ((a[i] + a[j]) % k == 0)
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
