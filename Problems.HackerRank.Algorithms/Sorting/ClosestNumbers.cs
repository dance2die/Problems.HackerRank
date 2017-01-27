using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
INPUT:
10
-20 -3916237 -357920 -3620601 7374819 -7330761 30 6246457 -6461594 266854
OUTPUT:
-20 30

INPUT:
12
-20 -3916237 -357920 -3620601 7374819 -7330761 30 6246457 -6461594 266854 -520 -470 
OUTPUT:
-520 -470 -20 30

INPUT:
4
5 4 3 2
OUTPUT:
2 3 3 4 4 5
*/
namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Closest Numbers
    /// https://www.hackerrank.com/challenges/closest-numbers
    /// </summary>
    public class ClosestNumbers
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();     // ignore array size
            var split = Console.ReadLine().Split(' ');
            var values = Array.ConvertAll(split, int.Parse);


            // Put differences in a dictionary.
            var differences = GetDifferences(values);

            // Find pair(s) with lowest differences.
            var lowestDifferences = GetLowestDifferences(differences);

            // convert the lookup dictionary as sorted array ascending
            var sortedDifferences = GetSortedDifferences(lowestDifferences);

            PrintDifferences(sortedDifferences);
        }

        private static IEnumerable<int> GetSortedDifferences(IEnumerable<Tuple<int, int>> lowestDifferences)
        {
            // "* 2" because tuple contains two elements per object.
            List<int> result = new List<int>();

            foreach (Tuple<int, int> pair in lowestDifferences)
            {
                result.AddRange(new[] {pair.Item1, pair.Item2});
            }

            return result.OrderBy(value => value);
        }

        /// <summary>
        /// Tuple contains two numbers compared.
        /// third type parameter, int, contains difference value
        /// </summary>
        private static IEnumerable<Tuple<int, int, int>> GetDifferences(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    var left = values[i];
                    var right = values[j];
                    var difference = Math.Abs(left - right);

                    yield return Tuple.Create(left, right, difference);
                }
            }
        }

        private static IEnumerable<Tuple<int, int>> GetLowestDifferences(
            IEnumerable<Tuple<int, int, int>> differences)
        {
            int minimumValue = differences.Min(tuple => tuple.Item3);
            var minimumDifferencePairs = differences.Where(tuple => tuple.Item3 == minimumValue);

            return minimumDifferencePairs.Select(tuple => Tuple.Create(tuple.Item1, tuple.Item2));
        }

        private static void PrintDifferences(IEnumerable<int> values)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var value in values)
            {
                builder.AppendFormat("{0} ", value);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
