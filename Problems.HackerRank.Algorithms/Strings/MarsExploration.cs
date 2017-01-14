using System;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Mars Exploration
    /// https://www.hackerrank.com/challenges/mars-exploration
    /// </summary>
    public class MarsExploration
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // input = SOSSPSSQSSOR
            // output = 3
            // input = SOSSOT
            // output = 1

            const string SOS = "SOS";
            int count = 0;
            for (int i = 0; i < input.Length; i += 3)
            {
                var substring = input.Substring(i, SOS.Length);
                if (substring != SOS)
                {
                    for (int j = 0; j < SOS.Length; j++)
                    {
                        if (substring[j] != SOS[j])
                            count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
