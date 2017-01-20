using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Beautiful Days at the Movies
    /// https://www.hackerrank.com/challenges/beautiful-days-at-the-movies
    /// </summary>
    public class BeautifulDayAtTheMovies
    {
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
            // input: 1 123456 13
            // output: 9657

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
            double quotient = (double)(value - reversedValue) / divisor;
            double remainder = quotient % 2;

            const double tolerance = 0.000000001;
            //return Math.Abs(remainder - 1) < tolerance || Math.Abs(remainder) < tolerance;
            return remainder == 1 || remainder == 0;
        }

        private static int GetReversed(int value)
        {
            var reversedString = new string(value.ToString().ToCharArray().Reverse().ToArray());
            return int.Parse(reversedString);
        }
    }
}
