using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemsHackerRank.Contests.Week_of_Code_31
{
    /// <summary>
    /// Accurate Sorting
    /// https://www.hackerrank.com/contests/w31/challenges/accurate-sorting
    /// </summary>
    public class AccurateSorting
    {
        public static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            List<int[]> testCases = GetTestCases(q).ToList();

            List<string> answers = AreSwappable(testCases).ToList();
            answers.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> AreSwappable(List<int[]> testCases)
        {
            foreach (int[] a in testCases)
            {
                yield return GetSwappableValue(a);
            }
        }

        private static string GetSwappableValue(int[] a)
        {
            return "No";
        }

        private static IEnumerable<int[]> GetTestCases(int q)
        {
            for (int i = 0; i < q; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                yield return a;
            }
        }
    }
}
