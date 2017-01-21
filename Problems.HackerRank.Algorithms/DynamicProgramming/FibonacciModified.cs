using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problems.HackerRank.Algorithms.DynamicProgramming
{
    /// <summary>
    /// Fibonacci Modified
    /// https://www.hackerrank.com/challenges/fibonacci-modified
    /// </summary>
    public class FibonacciModified
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int seed1 = int.Parse(input[0]);
            int seed2 = int.Parse(input[1]);
            int n = int.Parse(input[2]);
            // Input 0 1 5 
            // output 5

            BigInteger fibonacciNumber = GetModifiedFibonacciNumberAt(seed1, seed2, n);

            Console.WriteLine(fibonacciNumber);
        }

        private static BigInteger GetModifiedFibonacciNumberAt(int seed1, int seed2, int n)
        {
            // Seed the value array.
            List<BigInteger> values = new List<BigInteger>{seed1, seed2};

            for (int i = 0; i < n - 1; i++)
            {
                var nextNumber = values[i] + (values[i + 1] * values[i + 1]);
                values.Add(nextNumber);
            }

            return values[n - 1];
        }
    }
}
