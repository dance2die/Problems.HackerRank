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

INPUT:
1
3
1
2
OUTPUT: 2 3 4
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
            Dictionary<Tuple<int, int>, int> memoization = new Dictionary<Tuple<int, int>, int>();
            var diff1 = GetLastStones(accum, manasaStone.StoneCount, manasaStone.Diff1, manasaStone.Diff2, memoization).ToList();
            return diff1;
        }

        private static IEnumerable<int> GetLastStones(int accum, int stoneCount, int diff1, int diff2, Dictionary<Tuple<int, int>, int> memoization)
        {
            var tuple1 = Tuple.Create(stoneCount, diff1);
            var tuple2 = Tuple.Create(stoneCount, diff2);

            if (memoization.ContainsKey(tuple1))
            {
                yield return memoization[tuple1];
            }
            else if (memoization.ContainsKey(tuple2))
            {
                yield return memoization[tuple2];
            }
            else
            {
                if (stoneCount <= 1)
                {
                    yield return accum;
                }
                else
                {
                    var nextStoneCount = stoneCount - 1;

                    var nextSum1 = accum + diff1;
                    var diffSum1 = GetLastStones(nextSum1, nextStoneCount, diff1, diff2, memoization).ToList();
                    foreach (int sum1 in diffSum1)
                    {
                        var nextTuple1 = Tuple.Create(nextStoneCount, diff1);
                        if (!memoization.ContainsKey(nextTuple1))
                            memoization.Add(nextTuple1, sum1);

                        yield return sum1;
                    }

                    var nextSum2 = accum + diff2;
                    var diffSum2 = GetLastStones(nextSum2, nextStoneCount, diff2, diff1, memoization).ToList();
                    foreach (int sum2 in diffSum2)
                    {
                        var nextTuple2 = Tuple.Create(nextStoneCount, diff2);
                        if (!memoization.ContainsKey(nextTuple2))
                            memoization.Add(nextTuple2, sum2);

                        yield return sum2;
                    }
                }
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
