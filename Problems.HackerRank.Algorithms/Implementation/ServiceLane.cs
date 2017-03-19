using System;
using System.Collections.Generic;

/*
INPUT:
8 5
2 3 1 2 3 2 3 3
0 3
4 6
6 7
3 5
0 7
OUTPUT:
1
2
3
2
1
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Service Lane
    /// https://www.hackerrank.com/challenges/service-lane
    /// </summary>
    public class ServiceLane
    {
        static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] tempWidths = Console.ReadLine().Split(' ');
            int[] widths = Array.ConvertAll(tempWidths, int.Parse);

            List<int> minimums = new List<int>(t);
            for (int x = 0; x < t; x++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int i = Convert.ToInt32(tokens[0]);
                int j = Convert.ToInt32(tokens[1]);

                minimums.Add(GetMinimumBetween(widths, i, j));
            }

            minimums.ForEach(Console.WriteLine);
        }

        private static int GetMinimumBetween(int[] widths, int i, int j)
        {
            int minimum = int.MaxValue;
            const int lowest = 1;

            for (int k = i; k <= j ; k++)
            {
                if (widths[k] == lowest)
                    return lowest;

                if (widths[k] <= minimum)
                    minimum = widths[k];
            }

            return minimum;
        }
    }
}
