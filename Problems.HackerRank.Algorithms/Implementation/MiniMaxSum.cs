using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Mini-Max Sum
    /// https://www.hackerrank.com/challenges/mini-max-sum
    /// </summary>
    public class MiniMaxSum
    {
        public static void Main(string[] args)
        {
            List<BigInteger> input = Console.ReadLine().Split(' ').Select(str => BigInteger.Parse(str)).ToList();
            // input = 1 2 3 4 5
            // output = 10 14
            // input = 5 5 5 5 5
            // output = 20 20

            Stopwatch watch =  new Stopwatch();
            watch.Start();

            Tuple<BigInteger, BigInteger> sums1 = GetSums(input);
            var minSum1 = sums1.Item1;
            var maxSum1 = sums1.Item2;
            watch.Stop();
            Console.WriteLine("GetSums took {0}", watch.Elapsed);

            watch.Start();
            Tuple<BigInteger, BigInteger> sums2 = GetSums2(input);
            var minSum2 = sums2.Item1;
            var maxSum2 = sums2.Item2;
            watch.Stop();
            Console.WriteLine("GetSums2 took {0}", watch.Elapsed);

            Console.WriteLine("{0} {1}", minSum2, maxSum2);
        }

        private static Tuple<BigInteger, BigInteger> GetSums2(List<BigInteger> values)
        {
            BigInteger minValue = new BigInteger(long.MaxValue);
            BigInteger maxValue = new BigInteger(long.MinValue);

            // Get min/max values in one loop instead of two loops using LINQ.
            foreach (BigInteger value in values)
            {
                if (value < minValue) minValue = value;
                if (value > maxValue) maxValue = value;
            }

            var minValuesOnly = new List<BigInteger>(values.Count - 1);
            var maxValuesOnly = new List<BigInteger>(values.Count - 1);
            foreach (var value in values)
            {
                if (value != maxValue) minValuesOnly.Add(value);
                if (value != minValue) maxValuesOnly.Add(value);
            }

            Func<BigInteger, BigInteger, BigInteger> sum = (accum, value) => accum + value;

            BigInteger minSum = new BigInteger(0);
            BigInteger maxSum = new BigInteger(0);

            // if all values in a list is same; e.g.) 5 5 5 5 5
            if (minValuesOnly.Count == 0)
            {
                minSum = values.Skip(1).ToList().Aggregate(sum);
                maxSum = minSum;
            }
            else
            {
                for (int i = 0; i < minValuesOnly.Count; i++)
                {
                    minSum += minValuesOnly[i];
                    maxSum += maxValuesOnly[i];
                }
            }

            return Tuple.Create(minSum, maxSum);
        }

        private static Tuple<BigInteger, BigInteger> GetSums(List<BigInteger> input)
        {
            BigInteger maxValue = input.Max(value => value);
            BigInteger minValue = input.Min(value => value);

            Func<BigInteger, BigInteger, BigInteger> sum = (accum, value) => accum + value;

            var maxValuesOnly = input.Where(value => value != minValue).ToList();
            BigInteger maxSum =
                maxValuesOnly.Count == 0 ? input.Skip(1).Aggregate(sum) : maxValuesOnly.Aggregate(sum);

            var minValuesOnly = input.Where(value => value != maxValue).ToList();
            BigInteger minSum =
                minValuesOnly.Count == 0 ? input.Skip(1).Aggregate(sum) : minValuesOnly.Aggregate(sum);

            return Tuple.Create(minSum, maxSum);
        }
    }
}
