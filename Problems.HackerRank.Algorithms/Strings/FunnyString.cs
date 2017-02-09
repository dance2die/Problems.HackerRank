using System;
using System.Collections.Generic;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Funny String
    /// https://www.hackerrank.com/challenges/funny-string
    /// </summary>
    public class FunnyString
    {
        public static void Main(string[] args)
        {
            int testCaseCount = int.Parse(Console.ReadLine());
            var testCases = GetTestCases(testCaseCount);
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
