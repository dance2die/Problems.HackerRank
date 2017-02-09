using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Alternating Characters
    /// https://www.hackerrank.com/challenges/alternating-characters
    /// </summary>
    public class AlternatingCharacters
    {
        public static void Main()
        {
            int testCaseCount = int.Parse(Console.ReadLine());
            var testCases = GetTestCases(testCaseCount).ToList();
/*
INPUT:
5
AAAA
BBBBB
ABABABAB
BABABA
AAABBB
OUTPUT:
3
4
0
0
4
*/
            PrintTestCases(testCases);
        }

        private static void PrintTestCases(List<string> testCases)
        {
        }

        private static IEnumerable<string> GetTestCases(int testCaseCount)
        {
            for (int i = 0; i < testCaseCount; i++)
            {
                yield return Console.ReadLine();
            }
        }
    }
}
