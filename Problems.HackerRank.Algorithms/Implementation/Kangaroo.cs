using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Kangaroo
    /// https://www.hackerrank.com/challenges/kangaroo
    /// </summary>
    public class Kangaroo
    {
        public static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            // input 0 3 4 2 output YES
            // input 0 2 5 3 output NO

            // NO case
            if (x1 + v1 < x2 + v2)
            {
                Console.WriteLine("NO");
                return;
            }


        }
    }
}
