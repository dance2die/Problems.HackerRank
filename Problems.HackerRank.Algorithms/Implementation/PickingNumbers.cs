using System;
using System.Collections.Generic;
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

INPUT:
6
98 3 99 1 97 2
OUTPUT: 2
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Picking Numbers
    /// https://www.hackerrank.com/challenges/picking-numbers
    /// </summary>
    public class PickingNumbers
    {
        private const int MAX_SIZE = 100;

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(temp, int.Parse);

            int differenceCount = GetDifferenceCount3(a);
            Console.WriteLine(differenceCount);
        }

        /// <summary>
        /// Using algorithm in discussion in C++ by rishabhrajjha (https://www.hackerrank.com/rishabhrajjha?hr_r=1)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static int GetDifferenceCount3(int[] a)
        {
            List<int> map = Enumerable.Repeat(0, MAX_SIZE).ToList();
            for (int i = 0; i < a.Length; i++)
            {
                var key = a[i];
                map[key]++;
            }

            int maxCount = 0;
            for (int i = 0; i < map.Count - 1; i++)
            {
                var count = map[i] + map[i + 1];
                if (count > maxCount)
                    maxCount = count;
            }

            return maxCount;
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
