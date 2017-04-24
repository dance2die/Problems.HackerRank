using System;
using System.Linq;

/*
INPUT:
5
1 2 1 3 2
3 2
OUTPUT: 2

INPUT:
6
1 1 1 1 1 1
3 2
OUTPUT: 0

INPUT:
1
4
4 1
OUTPUT: 1

INPUT: #3
19
2 5 1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1
18 7
OUTPUT: 3
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Birthday Chocolate
    /// https://www.hackerrank.com/challenges/the-birthday-bar
    /// </summary>
    public static class BirthdayChocolate
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = GetWays(s, d, m);
            Console.WriteLine(result);
        }

        private static int GetWays(int[] a, int d, int m)
        {
            int ways = 0;

            int i = 0;
            do
            {
                int[] subArray = a.GetSubArray(i, m);
                if (subArray.Sum() == d)
                    ways++;

                i++;
            } while (i <= a.Length - m);

            return ways;
        }

        private static int[] GetSubArray(this int[] a, int index, int length)
        {
            var result = new int[length];
            Array.Copy(a, index, result, 0, length);
            return result;
        }
    }
}
