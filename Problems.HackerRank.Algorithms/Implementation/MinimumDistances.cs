using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Minimum Distances
    /// https://www.hackerrank.com/challenges/minimum-distances
    /// </summary>
    public class MinimumDistances
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] A_temp = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);
        }
    }
}
