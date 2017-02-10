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
            int middleIndex = testCase.Length / 2;
            Func<string, bool> hasEvenLength = str => str.Length % 2 == 0;

            var left = testCase.Substring(0, middleIndex);
            var right = testCase.Substring(hasEvenLength(testCase) ? middleIndex : middleIndex + 1).Reverse().ToArray();

            int countTotal = 0;
            for (int i = 0; i < middleIndex; i++)
            {
                char leftChar = left[i];
                char rightChar = right[i];

                if (leftChar == rightChar) continue;

                if (leftChar > rightChar)
                    countTotal += DecreaseCharUntil(leftChar, rightChar);
                else
                    countTotal += DecreaseCharUntil(rightChar, leftChar);
            }

            return countTotal;
        }

        /// <summary>
        /// Decrease c1 until c2
        /// </summary>
        private static int DecreaseCharUntil(char c1, char c2)
        {
            return c1 - c2;
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
