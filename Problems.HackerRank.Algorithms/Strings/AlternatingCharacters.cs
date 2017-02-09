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
AAABBB
AAAA
BBBBB
ABABABAB
BABABA
OUTPUT:
4
3
4
0
0

*/
            PrintTestCases(testCases);
        }

        private static void PrintTestCases(List<string> testCases)
        {
            foreach (var testCase in testCases)
            {
                int deleteCount = GetDeleteCount(testCase);
                Console.WriteLine(deleteCount);
            }
        }

        private static int GetDeleteCount(string testCase)
        {
            int count = 0;
            for (int i = 0; i < testCase.Length - 1; i++)
            {
                var c1 = testCase[i];
                var c2 = testCase[i + 1];
                if (c1 == c2)
                {
                    count++;
                }
            }

            return count;
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
