using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
9
10 5 20 20 4 5 2 25 1
OUTPUT: 2 4

INPUT:
10
3 4 21 36 10 28 35 5 24 42
OUTPUT: 4 0

INPUT:
6
0 9 3 10 2 20
OUTPUT: 3 0
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Breaking the Records
    /// https://www.hackerrank.com/challenges/breaking-best-and-worst-records
    /// </summary>
    public class BreakingTheRecords
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            List<int> result = GetRecord(s).ToList();
            Console.WriteLine(String.Join(" ", result));
        }

        public static IEnumerable<int> GetRecord(int[] a)
        {
            int maxCount = 0;
            int maxValue = int.MinValue;
            int minCount = 0;
            int minValue = int.MaxValue;

            foreach (int value in a)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                    maxCount++;
                }

                if (value < minValue)
                {
                    minValue = value;
                    minCount++;
                }
            }

            // Subtract one to offset initialization
            yield return maxCount - 1;
            yield return minCount - 1;
        }
    }
}
