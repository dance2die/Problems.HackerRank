using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Beautiful Days at the Movies
    /// https://www.hackerrank.com/challenges/beautiful-days-at-the-movies
    /// </summary>
    public class BeautifulDayAtTheMovies
    {
        private static readonly Dictionary<Tuple<int, int, int>, double> _remainders = new Dictionary<Tuple<int, int, int>, double>();
        private const double TOLERANCE = 1E-9;

        public static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');
            int i = int.Parse(ijk[0]);
            int j = int.Parse(ijk[1]);
            int k = int.Parse(ijk[2]);
            // input: 20 23 6
            // output: 2
            // input: 1 2000000 1000000000
            // output: 2998
            // test case #6
            // input: 1 123456 13
            // output: 9657
            // test case #7
            // input: 123 456789 189
            // output: 21841

            int counter = 0;
            for (int a = i; a <= j; a++)
            {
                if (IsBeautiful(a, k))
                    counter++;
            }

            Console.WriteLine(counter);
        }

        private static bool IsBeautiful(int value, int divisor)
        {
            int reversedValue = GetReversed(value);

            return IsEvenlyDivisible(value, reversedValue, divisor);
        }

        private static bool IsEvenlyDivisible(int value, int reversedValue, int divisor)
        {
            return (double) (value - reversedValue) % divisor == 0;
        }

        private static int GetReversed(int value)
        {
            var reversedString = new string(value.ToString().ToCharArray().Reverse().ToArray());
            return int.Parse(reversedString);
        }
    }
}
