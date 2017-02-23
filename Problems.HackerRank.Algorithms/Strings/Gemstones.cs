using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
3
abcdde
baccd
eeabg
OUTPUT: 2 (only 'a' and 'b' occur in common)
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Gemstones 
    /// https://www.hackerrank.com/challenges/gem-stones
    /// </summary>
    public class Gemstones
    {
        public static void Main()
        {
            // answer in discussion
            Console.WriteLine(
                Enumerable.Range(0, int.Parse(Console.ReadLine()))
                    .Select(_ => Console.ReadLine().AsEnumerable())
                    .Aggregate(Enumerable.Intersect).Count());

            return;
            int rockCount = int.Parse(Console.ReadLine());
            List<string> rocks = GetRocks(rockCount).ToList();

            int gemCount = GetCommonGemCount(rocks);
            Console.WriteLine(gemCount);
        }

        private static int GetCommonGemCount(List<string> rocks)
        {
            if (rocks.Count == 1) return rocks[0].Distinct().Count();

            HashSet<char> gems = new HashSet<char>(rocks[0]);
            for (int i = 1; i < rocks.Count; i++)
            {
                var nextGem = new HashSet<char>(rocks[i]);
                gems.IntersectWith(nextGem);
            }

            return gems.Distinct().Count();
        }

        private static IEnumerable<string> GetRocks(int rockCount)
        {
            for (int i = 0; i < rockCount; i++)
            {
                yield return Console.ReadLine();
            }
        }
    }
}
