/*
INPUT:
4
aba
baba
aba
xzxb
3
aba
xzxb
ab
OUTPUT:
2
1
0
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.DataStructure.Arrays
{
    /// <summary>
    /// Sparse Arrays
    /// https://www.hackerrank.com/challenges/sparse-arrays
    /// </summary>
    public class SparseArrays
    {
        public static void Main()
        {
            int textCount = int.Parse(Console.ReadLine());
            List<string> texts = GetTexts(textCount).ToList();
            int queryCount = int.Parse(Console.ReadLine());
            List<string> queries = GetTexts(queryCount).ToList();
        }

        private static IEnumerable<string> GetTexts(int textCount)
        {
            for (int i = 0; i < textCount; i++)
            {
                yield return Console.ReadLine();
            }
        }
    }
}
