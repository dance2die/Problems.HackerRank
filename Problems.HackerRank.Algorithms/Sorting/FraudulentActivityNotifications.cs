using System;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Fraudulent Activity Notifications
    /// https://www.hackerrank.com/challenges/fraudulent-activity-notifications
    /// </summary>
    public class FraudulentActivityNotifications
    {
        public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int arraySize = int.Parse(firstLine[0]);
            int days = int.Parse(firstLine[1]);

            var expenditures = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


/*
INPUT:
9 5
2 3 4 2 3 6 8 4 5
OUTPUT: 2
*/
        }
    }
}
