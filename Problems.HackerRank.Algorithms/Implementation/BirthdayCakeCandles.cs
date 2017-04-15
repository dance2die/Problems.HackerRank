using System;
using System.Linq;

/*
INPUT:
4
3 2 1 3
OUTPUT: 2
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Birthday Cake Candles
    /// https://www.hackerrank.com/challenges/birthday-cake-candles
    /// </summary>
    public class BirthdayCakeCandles
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] heights = Array.ConvertAll(height_temp, Int32.Parse);

            var max = heights.Max();
            int tallestCandles = heights.Count(val => val == max);
            Console.WriteLine(tallestCandles);
        }
    }
}
