﻿using System;
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

            // Get the intersect count between left and right texts
            // return the left.Length - intersect count

            return NOT_POSSIBLE;
        }

        private static bool IsLengthOdd(string text)
        {
            return text.Length % 2 == 1;
        }
    }
}
