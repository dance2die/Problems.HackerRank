using System;
using System.Collections.Generic;
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


            // Sort values.
            Array.Sort(values);

            // Get minimum by comparing adjacent values.
            int minimumValue = GetMinimum(values);

            // Get pairs matching the minimum value difference
            var minimumPairs = GetMinimumPairs(values, minimumValue);

            PrintDifferences(minimumPairs);
        }

        private static IEnumerable<int> GetMinimumPairs(int[] sortedValues, int minimumValue)
        {
            for (int i = 0; i < sortedValues.Length - 1; i++)
            {
                var left = sortedValues[i];
                var right = sortedValues[i + 1];
                var difference = Math.Abs(left - right);
                if (difference == minimumValue)
                {
                    yield return left;
                    yield return right;
                }
            }
        }

        public static int GetMinimum(int[] sortedValues)
        {
            int minimumValue = int.MaxValue;

            for (int i = 0; i < sortedValues.Length - 1; i++)
            {
                var difference = Math.Abs(sortedValues[i] - sortedValues[i + 1]);
                if (difference < minimumValue)
                    minimumValue = difference;
            }

            return minimumValue;
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
