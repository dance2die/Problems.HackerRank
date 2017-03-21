using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Fair Rations
    /// https://www.hackerrank.com/challenges/fair-rations
    /// </summary>
    public class FairRations
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] B_temp = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(B_temp, Int32.Parse);
        }
    }
}
