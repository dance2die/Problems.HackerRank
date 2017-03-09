using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
12
1012
OUTPUT:
2
3
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Find Digits
    /// https://www.hackerrank.com/challenges/find-digits
    /// </summary>
    public class FindDigits
    {
        public static void Main()
        {
            List<int> numbers = Enumerable.Range(0, int.Parse(Console.ReadLine()))
                .Select(_ => int.Parse(Console.ReadLine())).ToList();

            List<int> evenlyDivisibleNumberCounts = GetEvenlyDivisibleNumberCounts(numbers).ToList();
            evenlyDivisibleNumberCounts.ForEach(Console.WriteLine);
        }

        private static IEnumerable<int> GetEvenlyDivisibleNumberCounts(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                yield return GetEvenlyDivisibleNumberCount(number);
            }
        }

        private static int GetEvenlyDivisibleNumberCount(int number)
        {
            List<int> digits = GetDigits(number).ToList();
            Func<int, bool> isEvenlyDivisible = divisor => number % divisor == 0;

            int count = 0;

            foreach (int digit in digits)
            {
                if (digit == 0) continue;

                if (isEvenlyDivisible(digit))
                    count++;
            }

            return count;
        }

        private static IEnumerable<int> GetDigits(int number)
        {
            foreach (var c in number.ToString())
            {
                yield return int.Parse(c.ToString());
            }
        }
    }
}
