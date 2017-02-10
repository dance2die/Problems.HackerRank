using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Between Two Sets
    /// https://www.hackerrank.com/challenges/between-two-sets
    /// </summary>
    public class BetweenTwoSets
    {
        public static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, int.Parse);
        }
    }
}
