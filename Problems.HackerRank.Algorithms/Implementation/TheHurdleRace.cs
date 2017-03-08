using System;
using System.Linq;

/*
INPUT:
5 4
1 6 3 5 2
OUTPUT: 2
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// The Hurdle Race
    /// https://www.hackerrank.com/challenges/the-hurdle-race
    /// </summary>
    public class TheHurdleRace
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens[0]);
            int k = Convert.ToInt32(tokens[1]);
            string[] heightLines = Console.ReadLine().Split(' ');
            int[] heights = Array.ConvertAll(heightLines, int.Parse);

            int maxMagicBeverageCount = GetMaxBeverageCount(k, heights);
            Console.WriteLine(maxMagicBeverageCount);
        }

        private static int GetMaxBeverageCount(int k, int[] heights)
        {
            int max = heights.Max();
            if (k > max)
                return 0;
            return max - k;
        }
    }
}
