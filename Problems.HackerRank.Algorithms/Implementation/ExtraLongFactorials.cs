using System;
using System.Numerics;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Extra Long Factorials
    /// https://www.hackerrank.com/challenges/extra-long-factorials
    /// </summary>
    public class ExtraLongFactorials
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger factorials = GetFactorials(n);
            Console.WriteLine(factorials);
        }

        private static BigInteger GetFactorials(int n)
        {
            BigInteger result = BigInteger.One;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
