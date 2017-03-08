using System;
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
            IEnumerable<Tuple<int, int>> cases = GetCases(caseCount);

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

            HashSet<int> set = new HashSet<int>(Enumerable.Range(testCase.Item1, testCase.Item2 - testCase.Item1 + 1));
            var copySet = new HashSet<int>(set);

            foreach (int value in set)
            {
                if (IsSquareNumber(value))
                {
                    copySet.Remove(value);
                    count++;

                    // remove power of value
                    for (int i = value; i < set.Count; i++)
                    {
                        count += copySet.RemoveWhere(val => val == value * value);
                    }
                }
            }

            //for (int i = testCase.Item1; i <= testCase.Item2; i++)
            //{
            //    if (IsSquareNumber(i))
            //        count++;
            //}

            return count;
        }

        // http://stackoverflow.com/a/343862/4035
        private static bool IsSquareNumber(int value)
        {
            var sqrt = (long)Math.Sqrt(value);
            return sqrt * sqrt == value;
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
