using System;
using System.Linq;

/*
INPUT:
6
4 6 5 3 3 1
OUTPUT: 3

INPUT:
6
1 2 2 3 1 2
OUTPUT: 5
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Picking Numbers
    /// https://www.hackerrank.com/challenges/picking-numbers
    /// </summary>
    public class PickingNumbers
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(temp, int.Parse);

            int differenceCount = GetDifferenceCount2(a);
            Console.WriteLine(differenceCount);
        }

        private static int GetDifferenceCount2(int[] a)
        {
            int maxCount = 0;

            foreach (int currentValue in a)
            {
                var rest = a.Where(val => val != currentValue);
                var higher = rest.Where(val => 0 <= val - currentValue && val - currentValue <= 1);
                var lower = rest.Where(val => 0 <= currentValue - val && currentValue - val <= 1);
                var same = a.Where(val => val == currentValue);

                var currentCount = Math.Max(lower.Count(), higher.Count()) + same.Count();
                if (currentCount > maxCount)
                    maxCount = currentCount;
            }

            return maxCount;
        }
    }
}
