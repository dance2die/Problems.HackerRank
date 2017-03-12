using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Chocolate Feast
    /// https://www.hackerrank.com/challenges/chocolate-feast?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    /// </summary>
    public class ChocolateFeast
    {
        public static void Main()
        {
            int testCaseCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCaseCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens[0]);
                int c = Convert.ToInt32(tokens[1]);
                int m = Convert.ToInt32(tokens[2]);
            }
        }
    }
}
