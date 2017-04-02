using System;

/*
INPUT: 4 OUTPUT 6
INPUT: 7 OUTPUT 3
INPUT: 52 OUTPUT 42
INPUT: 93 OUTPUT 1
INPUT: 1000000000000 OUTPUT: 649267441662
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Strange Counter
    /// https://www.hackerrank.com/challenges/strange-code
    /// </summary>
    public class StrangeCounter
    {
        private const int INCREASE_AMOUNT = 3;

        public static void Main()
        {
            long t = Convert.ToInt64(Console.ReadLine());
            long counter = GetCounter(t);
            Console.WriteLine(counter);
        }

        private static long GetCounter(long t)
        {
            long prevLeftStart = 0;
            long prevLeftEnd = 0;
            long prevRightStart = 0;

            for (int i = 1; i <= t; i++)
            {
                long leftStart = prevLeftStart + GetLeftStart(i);
                long leftEnd = prevLeftEnd + GetLeftEnd(i);

                if (leftStart <= t && t <= leftEnd)
                {
                    long offset = t - leftStart;
                    long rightStart = GetRightStart(i);

                    return rightStart - offset;
                }

                prevLeftStart = leftStart;
                prevLeftEnd = leftEnd;
            }

            return -1;
        }

        private static long GetLeftStart(long t)
        {
            if (t == 1) return 1;
            return INCREASE_AMOUNT * (long)Math.Pow(2, t - 2);
        }

        private static long GetLeftEnd(long t)
        {
            if (t == 1) return INCREASE_AMOUNT;
            return INCREASE_AMOUNT * (long) Math.Pow(2, t - 1);
        }

        private static long GetRightStart(long t)
        {
            if (t == 1) return INCREASE_AMOUNT;
            return INCREASE_AMOUNT * (long) Math.Pow(2, t - 1);
        }
    }
}
