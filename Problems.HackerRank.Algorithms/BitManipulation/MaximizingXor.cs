using System;

namespace Problems.HackerRank.Algorithms.BitManipulation
{
    /// <summary>
    /// Maximizing XOR
    /// https://www.hackerrank.com/challenges/maximizing-xor
    /// </summary>
    public class MaximizingXor
    {
        public static void Main(string[] args)
        {
            var left = Convert.ToInt32(Console.ReadLine());
            var right = Convert.ToInt32(Console.ReadLine());

/*
INPUT:
10
15
OUTPUT: 7

INPUT:
5
6
OUTPUT: 3
*/

            var result = MaxXor(left, right);
            Console.WriteLine(result);
        }

        public static int MaxXor(int left, int right)
        {
            int max = 0;
            Func<int, string> toBin = v => Convert.ToString(v, 2);

            for (int i = left; i <= right; i++)
            {
                for (int j = left; j <= right; j++)
                {
                    var xorValue = i ^ j;
                    //Console.WriteLine("{0}({1}) ^ {2}({3}) = {4}({5})", i, toBin(i), j, toBin(j), xorValue, toBin(xorValue));
                    if (xorValue > max)
                        max = xorValue;
                }
            }

            return max;
        }
    }
}
