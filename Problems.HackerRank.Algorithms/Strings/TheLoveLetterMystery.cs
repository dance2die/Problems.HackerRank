using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// The Love-Letter Mystery
    /// https://www.hackerrank.com/challenges/the-love-letter-mystery
    /// </summary>
    public class TheLoveLetterMystery
    {
        public static void Main(string[] args)
        {
            int testCaseCount = int.Parse(Console.ReadLine());
            var testCases = GetTestCases(testCaseCount).ToList();
/*
INPUT:
4
abc
abcba
abcd
cba
OUTPUT:
2
0
4
2
*/
            PrintTestCases(testCases);
        }

        private static void PrintTestCases(List<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                int count = GetPalindromeConversionCount(testCase);
                Console.WriteLine(count);
            }
        }

        private static int GetPalindromeConversionCount(string testCase)
        {
            return -1;
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
