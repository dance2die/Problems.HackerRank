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
4
10
100
OUTPUT: 30 120 210 300

INPUT:
1
3
1
2
OUTPUT: 2 3 4

INPUT:
5
58
69
24
83
86
81
73
25
25
12
73
82
5
3
23
OUTPUT:
1368 1413 1458 1503 1548 1593 1638 1683 1728 1773 1818 1863 1908 1953 1998 2043 2088 2133 2178 2223 2268 2313 2358 2403 2448 2493 2538 2583 2628 2673 2718 2763 2808 2853 2898 2943 2988 3033 3078 3123 3168 3213 3258 3303 3348 3393 3438 3483 3528 3573 3618 3663 3708 3753 3798 3843 3888 3933
6642 6647 6652 6657 6662 6667 6672 6677 6682 6687 6692 6697 6702 6707 6712 6717 6722 6727 6732 6737 6742 6747 6752 6757 6762 6767 6772 6777 6782 6787 6792 6797 6802 6807 6812 6817 6822 6827 6832 6837 6842 6847 6852 6857 6862 6867 6872 6877 6882 6887 6892 6897 6902 6907 6912 6917 6922 6927 6932 6937 6942 6947 6952 6957 6962 6967 6972 6977 6982 6987 6992 6997 7002 7007 7012 7017 7022 7027 7032 7037 7042 7047 7052
1800
803 812 821 830 839 848 857 866 875 884 893 902
12 32 52 72 92

INPUT:
1
58
69
24
OUTPUT:
1368 1413 1458 1503 1548 1593 1638 1683 1728 1773 1818 1863 1908 1953 1998 2043 2088 2133 2178 2223 2268 2313 2358 2403 2448 2493 2538 2583 2628 2673 2718 2763 2808 2853 2898 2943 2988 3033 3078 3123 3168 3213 3258 3303 3348 3393 3438 3483 3528 3573 3618 3663 3708 3753 3798 3843 3888 3933


INPUT:
1
5
3
23
OUTPUT: 12 32 52 72 92
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
                var ordered = GetLastStones(manasaStone).OrderBy(val => val);
                List<int> stones = ordered.Distinct().ToList();
                yield return string.Join(" ", stones.Select(val => val.ToString()).ToArray());
            }
        }

        private static List<int> GetLastStones(ManasaStone manasaStone)
        {
            int accum = 0;
            var diff1 = GetLastStones(accum, manasaStone.StoneCount, manasaStone.Diff1, manasaStone.Diff2).ToList();
            return diff1;
        }

        private static IEnumerable<int> GetLastStones(int accum, int stoneCount, int diff1, int diff2)
        {
            var nextSum1 = accum + diff1;
            var nextSum2 = accum + diff2;

            if (stoneCount <= 2)
            {
                yield return nextSum1;
                yield return nextSum2;
            }
            else
            {
                var nextStoneCount = stoneCount - 1;

                //var diffSum1 = GetLastStones(nextSum1, nextStoneCount, diff1, diff2).ToList();
                var diffSum1 = new HashSet<int>(GetLastStones(nextSum1, nextStoneCount, diff1, diff2));
                foreach (int sum1 in diffSum1)
                {
                    yield return sum1;
                }

                //var diffSum2 = GetLastStones(nextSum2, nextStoneCount, diff1, diff2).ToList();
                var diffSum2 = new HashSet<int>(GetLastStones(nextSum2, nextStoneCount, diff1, diff2));
                foreach (int sum2 in diffSum2)
                {
                    yield return sum2;
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
