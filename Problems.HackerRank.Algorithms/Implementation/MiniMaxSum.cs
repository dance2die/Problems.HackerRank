using System;
using System.Collections.Generic;
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


            BigInteger maxValue = input.Max(value => value);
            BigInteger minValue = input.Min(value => value);

            Func<BigInteger, BigInteger, BigInteger> sum = (accum, value) => accum + value;

            var maxValuesOnly = input.Where(value => value != minValue).ToList();
            BigInteger maxSum = 
                maxValuesOnly.Count == 0 ? input.Skip(1).Aggregate(sum) : maxValuesOnly.Aggregate(sum);

            var minValuesOnly = input.Where(value => value != maxValue).ToList();
            BigInteger minSum =
                minValuesOnly.Count == 0 ? input.Skip(1).Aggregate(sum) : minValuesOnly.Aggregate(sum);

            Console.WriteLine("{0} {1}", minSum, maxSum);
        }
    }
}
