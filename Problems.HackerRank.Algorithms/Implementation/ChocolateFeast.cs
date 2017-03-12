using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
3
10 2 5
12 4 4
6 2 2
OUTPUT:
6
3
5
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Chocolate Feast
    /// https://www.hackerrank.com/challenges/chocolate-feast?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    /// </summary>
    public class ChocolateFeast
    {
        public static void Main()
        {
            int testCaseCount = Convert.ToInt32(Console.ReadLine());
            List<Tuple<int, int, int>> testCases = new List<Tuple<int, int, int>>(testCaseCount);
            for (int i = 0; i < testCaseCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens[0]);
                int c = Convert.ToInt32(tokens[1]);
                int m = Convert.ToInt32(tokens[2]);

                testCases.Add(Tuple.Create(n, c, m));
            }

            List<int> counts = GetChocolateCounts(testCases).ToList();
            counts.ForEach(Console.WriteLine);
        }

        private static IEnumerable<int> GetChocolateCounts(List<Tuple<int, int, int>> testCases)
        {
            foreach (Tuple<int, int, int> testCase in testCases)
            {
                yield return GetChocolateCount(testCase);
            }
        }

        private static int GetChocolateCount(Tuple<int, int, int> testCase)
        {
            int n = testCase.Item1;
            int c = testCase.Item2;
            int m = testCase.Item3;

            int chocolates = n / c;
            int wrappers = chocolates;

            while (wrappers >= m)
            {
                int currentChocolate = wrappers / m;
                wrappers = currentChocolate + (wrappers % m);
                chocolates += currentChocolate;
            }

            return chocolates;
        }
    }
}
