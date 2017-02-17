﻿using System;
using System.Linq;

/*
INPUT:
5 3 4
3 2 1 1 1
4 3 2
1 1 4 1
OUTPUT: 5

INPUT:
5 2 3
1 1 1 1 1
3 2
1 3 1
OUTPUT: 5
 */
namespace Problems.HackerRank.DataStructure.Stacks
{
    /// <summary>
    /// Equal Stacks
    /// https://www.hackerrank.com/challenges/equal-stacks
    /// </summary>
    public class EqualStacks
    {
        public static void Main()
        {
            string[] tokens_n1 = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(tokens_n1[0]);
            int n2 = Convert.ToInt32(tokens_n1[1]);
            int n3 = Convert.ToInt32(tokens_n1[2]);
            string[] h1_temp = Console.ReadLine().Split(' ');
            int[] h1 = Array.ConvertAll(h1_temp, int.Parse);
            string[] h2_temp = Console.ReadLine().Split(' ');
            int[] h2 = Array.ConvertAll(h2_temp, int.Parse);
            string[] h3_temp = Console.ReadLine().Split(' ');
            int[] h3 = Array.ConvertAll(h3_temp, int.Parse);

            int commonMaximumHeight = GetCommonMaximumHeight(h1, h2, h3);
            Console.WriteLine(commonMaximumHeight);
        }

        private static int GetCommonMaximumHeight(int[] h1, int[] h2, int[] h3)
        {
            int[] h1Accumulated = Accumulate(h1);
            int[] h2Accumulated = Accumulate(h2);
            int[] h3Accumulated = Accumulate(h3);

            var reversed = h1Accumulated.Reverse();
            foreach (int value in reversed)
            {
                if (h2Accumulated.Contains(value) && h3Accumulated.Contains(value))
                    return value;
            }

            return 0;
        }

        private static int[] Accumulate(int[] a)
        {
            int[] result = new int[a.Length];
            // accumulate from the beginning in reverse order.
            for (int i = a.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int nextValue = j - 1 < 0 ? 0 : result[j - 1];
                result[j] += a[i] + nextValue;
            }
            return result;
        }
    }
}
