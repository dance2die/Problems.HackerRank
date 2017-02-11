using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
3
0
1
4
OUTPUT:
1
2
7
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Utopian Tree
    /// https://www.hackerrank.com/challenges/utopian-tree
    /// </summary>
    public class UtopianTree
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<int> cycles = GetCycles(t).ToList();

            PrintHeights(cycles);
        }

        private static void PrintHeights(List<int> cycles)
        {
            foreach (int cycle in cycles)
            {
                int height = GetHeight(cycle);
                Console.WriteLine(height);
            }
        }

        private static int GetHeight(int cycle)
        {
            const int initialHeight = 1;
            int height = initialHeight;

            if (cycle <= 0) return initialHeight;

            Func<int, bool> isSummerCycle = val => val % 2 == 1;
            for (int i = 1; i <= cycle; i++)
            {
                if (isSummerCycle(i))
                    height *= 2;
                else
                    height++;
            }

            return height;
        }

        private static IEnumerable<int> GetCycles(int t)
        {
            for (int a0 = 0; a0 < t; a0++)
            {
                yield return Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
