using System;
using System.Linq;

namespace ProblemsHackerRank.Contests.RookieRank
{
    /// <summary>
    /// Birthday Cake Candles
    /// https://www.hackerrank.com/contests/rookierank/challenges/birthday-cake-candles?utm_source=rookierank-2-reminder-24hrs&amp;utm_medium=email&amp;utm_campaign=rookierank-2
    /// </summary>
    public class BirthdayCakeCandles
    {
        public static void Main()
        {
            int candleCount = int.Parse(Console.ReadLine());
            int[] candelHeights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
/*
INPUT:
4
3 2 1 3
OUTPUT: 2
*/

            int blowCount = GetBlowableCandleCount(candelHeights);
            Console.WriteLine(blowCount);
        }

        private static int GetBlowableCandleCount(int[] candelHeights)
        {
            int maxHeight = candelHeights.Max(height => height);
            return candelHeights.Count(height => height == maxHeight);
        }
    }
}
