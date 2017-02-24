using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
INPUT:
3
aaab
baa
aaa
OUTPUT:
3
0
-1
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Palindrome Index
    /// https://www.hackerrank.com/challenges/palindrome-index
    /// </summary>
    public class PalindromeIndex
    {
        public static void Main()
        {
            //List<string> testCases = Enumerable.Range(0, int.Parse(Console.ReadLine()))
            //    .Select(_ => Console.ReadLine()).ToList();

            var testCases = File.ReadAllLines(@".\Strings\PalindromeIndexes_TestCase06.txt");

            PrintPalindromeIndexes(testCases.Skip(1).ToList());
        }

        private static void PrintPalindromeIndexes(IList<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                Console.WriteLine(GetRemovedIndex(testCase));
            }
        }

        /// <remarks>
        /// Partially copied from TheLoveLetterMystery
        /// </remarks>
        private static int GetRemovedIndex(string testCase)
        {
            if (IsPalindrome(testCase)) return -1;

            for (int i = 0; i < testCase.Length; i++)
            {
                var tempCase = testCase.Remove(i, 1);
                if (IsPalindrome(tempCase))
                    return i;
            }

            return -1;
        }

        private static bool IsPalindrome(string testCase)
        {
            //int middleIndex = testCase.Length / 2;
            //Func<string, bool> hasEvenLength = str => str.Length % 2 == 0;
            //var left = testCase.Substring(0, middleIndex);
            //var right = new string(testCase.Substring(hasEvenLength(testCase) ? middleIndex : middleIndex + 1).Reverse().ToArray());

            //return left == right;

            return testCase.SequenceEqual(testCase.Reverse());
        }
    }
}
