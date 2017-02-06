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
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = MaxXor(_l, _r);
            Console.WriteLine(res);
        }

        static int MaxXor(int l, int r)
        {
            return -1;
        }
    }
}
