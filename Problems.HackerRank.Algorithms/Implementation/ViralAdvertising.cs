using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Viral Advertising
    /// https://www.hackerrank.com/challenges/strange-advertising
    /// </summary>
    public class ViralAdvertising
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // n = 3? output = 9

            int initialPeople = 5;
            int accum = 0;
            int nextCount = 0;
            for (int i = 0; i < n; i++)
            {
                var currentCount = i == 0 ? initialPeople : nextCount * 3;
                nextCount = GetNextCount(currentCount);
                accum += nextCount;
            }

            Console.WriteLine(accum);
        }

        private static int GetNextCount(int peopleCount)
        {
            return (int) Math.Floor((double) peopleCount / 2);
        }
    }
}
