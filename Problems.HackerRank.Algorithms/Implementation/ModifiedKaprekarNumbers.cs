using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
1
100
OUTPUT: 1 9 45 55 99
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

            int squared = number * number;
            //List<int> digits = GetDigits(squared).ToList();
            Tuple<int, int> separated = GetLeftRightNumbers(squared);

            return separated.Item1 + separated.Item2 == number;
        }

        private static Tuple<int, int> GetLeftRightNumbers(int number)
        {
            string numberText = number.ToString();
            int middleIndex = numberText.Length / 2;

            int left = int.Parse(numberText.Substring(0, middleIndex));
            int right = int.Parse(numberText.Substring(middleIndex));

            return Tuple.Create(left, right);
        }

        //private static Tuple<int, int> GetLeftRightNumbers(List<int> digits)
        //{
        //    int middleIndex = digits.Count / 2;
        //    int left = digits.GetRange(0, middleIndex).Select();
        //}

        //private static IEnumerable<int> GetDigits(int squared)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    int number = squared;

        //    while (number > 0)
        //    {
        //        int digit = number % 10;
        //        stack.Push(digit);

        //        number /= 10;
        //    }

        //    return stack.ToList();
        //}
    }
}
