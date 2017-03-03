using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// ACM ICPC Team
    /// https://www.hackerrank.com/challenges/acm-icpc-team?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    /// </summary>
    public class AcmIcpcTeam
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] topic = new string[n];
            for (int topic_i = 0; topic_i < n; topic_i++)
            {
                topic[topic_i] = Console.ReadLine();
            }
        }
    }
}
