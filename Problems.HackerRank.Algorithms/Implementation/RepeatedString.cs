using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Repeated String
    /// https://www.hackerrank.com/challenges/repeated-string
    /// </summary>
    public class RepeatedString
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            // s = aba
            // n = 10
            // output 7
            // s = x
            // n = 970770
            // output 0


            // Second edge case.
            if (s.IndexOf("a", StringComparison.Ordinal) < 0)
            {
                Console.WriteLine(0);
                return;
            }

            // Edge case check.
            if (s.Length == 1)
            {
                Console.WriteLine(n);
                return;
            }

            int inputCountOfA = s.Count(c => c == 'a');

            long remainder = n / s.Length;
            int leftOverCount = (int) (n - (remainder*s.Length));

            var sum = inputCountOfA * remainder;
            int leftOverCountOfA = s.Substring(0, leftOverCount).Count(c => c == 'a');
            var totalCountOfA = sum + leftOverCountOfA;

            Console.WriteLine(totalCountOfA);
        }
    }
}
