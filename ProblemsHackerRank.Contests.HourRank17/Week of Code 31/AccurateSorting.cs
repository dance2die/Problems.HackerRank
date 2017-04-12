using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
4
1 0 3 2
3
2 1 0
OUTPUT:
Yes
No
 */
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
            var original = a.ToList();

            for (int i = 0; i < a.Length - 1; i++)
            {
                var left = a[i];
                var right = a[i + 1];
                if ((left - right) == 1)
                {
                    Swap(a, i, i + 1);
                }
            }

            original.Sort();
            if (original.SequenceEqual(a))
                return "Yes";
            return "No";
        }

        private static void Swap(int[] a, int i1, int i2)
        {
            var temp = a[i1];
            a[i1] = a[i2];
            a[i2] = temp;
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
