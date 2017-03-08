﻿using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
3 9
17 24
OUTPUT:
2
0
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Sherlock and Squares
    /// https://www.hackerrank.com/challenges/sherlock-and-squares?h_r=internal-search
    /// </summary>
    public class SherlockAndSquares
    {
        public static void Main()
        {
            int caseCount = int.Parse(Console.ReadLine());
            IEnumerable<Tuple<int, int>> cases = GetCases(caseCount).ToList();

            List<int> squareCounts = GetSquareCounts(cases).ToList();
            squareCounts.ForEach(Console.WriteLine);
        }

        private static IEnumerable<int> GetSquareCounts(IEnumerable<Tuple<int, int>> testCases)
        {
            foreach (Tuple<int, int> testCase in testCases)
            {
                yield return GetSquareCount(testCase);
            }
        }

        private static int GetSquareCount(Tuple<int, int> testCase)
        {
            int count = 0;

            HashSet<int> processed = new HashSet<int>();
            for (int i = (int)Math.Sqrt(testCase.Item1); i <= Math.Sqrt(testCase.Item2); i++)
            {
                var power = i * i;
                if (testCase.Item1 <= power && power <= testCase.Item2)
                {
                    processed.Add(i);
                    count++;
                }
            }

            return count;
        }

        private static IEnumerable<Tuple<int, int>> GetCases(int caseCount)
        {
            for (int i = 0; i < caseCount; i++)
            {
                var split = Console.ReadLine().Split(' ');
                yield return Tuple.Create(int.Parse(split[0]), int.Parse(split[1]));
            }
        }
    }
}
