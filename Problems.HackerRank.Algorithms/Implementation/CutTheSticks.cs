using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Cut the sticks
    /// https://www.hackerrank.com/challenges/cut-the-sticks
    /// </summary>
    public class CutTheSticks
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] tempA = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(tempA, int.Parse);
        }
    }
}
