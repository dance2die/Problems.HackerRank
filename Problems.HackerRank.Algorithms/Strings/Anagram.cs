using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
6
aaabbb
ab
abc
mnop
xyyx
xaxbbbxx
OUTPUT:
3
1
-1
2
0
1
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Anagram 
    /// https://www.hackerrank.com/challenges/anagram
    /// </summary>
    public class Anagram
    {
        private const int NOT_POSSIBLE = -1;

        public static void Main(string[] args)
        {
            List<string> testCases = 
                Enumerable.Range(0, int.Parse(Console.ReadLine()))
                .Select(_ => Console.ReadLine()).ToList();
            PrintResults(testCases);
        }

        private static void PrintResults(List<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                int changeCount = GetChangeCountForAnagram(testCase);
                Console.WriteLine(changeCount);
            }
        }

        private static int GetChangeCountForAnagram(string testCase)
        {
            if (IsLengthOdd(testCase)) return NOT_POSSIBLE;

            // Parse test case for left and right texts
            int middleIndex = testCase.Length / 2;
            var left = testCase.Substring(0, middleIndex).ToCharArray();
            var right = testCase.Substring(middleIndex).ToCharArray();

            Array.Sort(left);
            Array.Sort(right);

            // Get the exception from left to right.
            var exceptions = left.Except(right);
            int total = 0;
            foreach (char exception in exceptions)
            {
                total += left.Count(c => c == exception);
            }

            return total;
        }

        private static bool IsLengthOdd(string text)
        {
            return text.Length % 2 == 1;
        }
    }
}
