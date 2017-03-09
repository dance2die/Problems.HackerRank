using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Jumping on the Clouds: Revisited
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited
    /// </summary>
    public class JumpingOnTheCloudsRevisited
    {
        public static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens[0]);
            int k = Convert.ToInt32(tokens[1]);
            string[] temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(temp, int.Parse);
        }
    }
}
