using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
3 
1
2
4
10
100
OUTPUT:
2 3 4 
30 120 210 300 
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Manasa and Stones
    /// https://www.hackerrank.com/challenges/manasa-and-stones
    /// </summary>
    public class ManasaAndStones
    {
        public static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            List<ManasaStone> manasaStones = GetManasaStones(T).ToList();
            List<string> values = GetLastStoneList(manasaStones).ToList();

            values.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> GetLastStoneList(List<ManasaStone> manasaStones)
        {
            foreach (ManasaStone manasaStone in manasaStones)
            {
                List<int> stones = GetLastStones(manasaStone).OrderBy(val => val).Distinct().ToList();
                yield return string.Join(" ", stones.Select(val => val.ToString()).ToArray());
            }
        }

        private static List<int> GetLastStones(ManasaStone manasaStone)
        {
            int accum = 0;
            Dictionary<int, int> memoization = new Dictionary<int, int>();
            var diff1 = GetLastStones(accum, manasaStone.StoneCount, manasaStone.Diff1, manasaStone.Diff2, memoization).ToList();
            return diff1;
        }

        private static IEnumerable<int> GetLastStones(int accum, int stoneCount, int diff1, int diff2, IDictionary<int, int> memoization)
        {
            if (stoneCount <= 1)
            {
                yield return accum;
            }
            else
            {
                var nextSum1 = accum + diff1;
                var nextSum2 = accum + diff2;

                var diffSum1 = GetLastStones(nextSum1, stoneCount - 1, diff1, diff2, memoization).ToList();
                var diffSum2 = GetLastStones(nextSum2, stoneCount - 1, diff2, diff2, memoization).ToList();

                diffSum1.AddRange(diffSum2);

                foreach (int sum in diffSum1)
                    yield return sum;
            }
        }

        private static IEnumerable<ManasaStone> GetManasaStones(int testCaseCount)
        {
            for (int i = 0; i < testCaseCount; i++)
            {
                int stoneCount = int.Parse(Console.ReadLine());
                int diff1 = int.Parse(Console.ReadLine());
                int diff2 = int.Parse(Console.ReadLine());

                yield return new ManasaStone(stoneCount, diff1, diff2);
            }
        }
    }

    public class ManasaStone
    {
        public int StoneCount { get; set; }
        public int Diff1 { get; set; }
        public int Diff2 { get; set; }

        public ManasaStone(int stoneCount, int diff1, int diff2)
        {
            StoneCount = stoneCount;
            Diff1 = diff1;
            Diff2 = diff2;
        }
    }
}
