using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
1
100
OUTPUT: 1 9 45 55 99

INPUT:
400
700
OUTPUT: INVALID RANGE

INPUT:
1
99999
OUTPUT: 1 9 45 55 99 297 703 999 2223 2728 4950 5050 7272 7777 9999 17344 22222 77778 82656 95121 99999
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Modified Kaprekar Numbers
    /// https://www.hackerrank.com/challenges/kaprekar-numbers
    /// </summary>
    public class ModifiedKaprekarNumbers
    {
        public static void Main()
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            List<string> kaprekarNumbers = GetKaprekarNumbersBetween(p, q).ToList();

            if (kaprekarNumbers.Count == 0)
                Console.WriteLine("INVALID RANGE");
            else
                Console.WriteLine(string.Join(" ", kaprekarNumbers));
        }

        private static IEnumerable<string> GetKaprekarNumbersBetween(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                if (IsKaprekarNumber(i))
                    yield return i.ToString();
            }
        }

        private static bool IsKaprekarNumber(int number)
        {
            if (number == 1) return true;
            if (2 <= number && number <= 8) return false;

            double squared = Math.Pow(number, 2);
            Tuple<long, long> separated = GetLeftRightNumbers(squared);

            return separated.Item1 + separated.Item2 == number;
        }

        private static Tuple<long, long> GetLeftRightNumbers(double number)
        {
            string numberText = number.ToString();
            int middleIndex = numberText.Length / 2;

            long left = long.Parse(numberText.Substring(0, middleIndex));
            long right = long.Parse(numberText.Substring(middleIndex));

            return Tuple.Create(left, right);
        }
    }
}
