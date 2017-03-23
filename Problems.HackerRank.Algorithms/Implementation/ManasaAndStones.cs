using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int testCaseCount = int.Parse(Console.ReadLine());
            List<ManasaStone> manasaStones = GetManasaStones(testCaseCount).ToList();
            List<string> values = GetLastStoneList(manasaStones).ToList();

            values.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> GetLastStoneList(List<ManasaStone> manasaStones)
        {
            yield break;
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
