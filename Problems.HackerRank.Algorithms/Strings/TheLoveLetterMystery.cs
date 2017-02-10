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
