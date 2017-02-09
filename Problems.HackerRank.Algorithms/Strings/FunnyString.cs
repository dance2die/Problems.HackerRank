using System;
using System.Collections.Generic;
using System.Linq;

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
            var testCases = GetTestCases(testCaseCount).ToList();

/*
INPUT:
2
acxz
bcxz
OUTPUT:
Funny
Not Funny 
*/
            PrintTestCases(testCases);
        }

        private static void PrintTestCases(IEnumerable<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                Console.WriteLine(IsFunny(testCase) ? "Funny" : "Not Funny");
            }
        }

        private static bool IsFunny(string s)
        {
            var r = s.Reverse().ToList();
            for (int i = s.Length - 1; i > 0; i--)
            {
                int diff1 = Math.Abs(s[i] - s[i - 1]);
                int diff2 = Math.Abs(r[i] - r[i - 1]);
                if (diff1 != diff2)
                    return false;
            }
            return true;
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
