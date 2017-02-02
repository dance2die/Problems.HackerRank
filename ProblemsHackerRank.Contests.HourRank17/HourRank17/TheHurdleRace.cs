using System;

namespace ProblemsHackerRank.Contests.HourRank17
{
    public class TheHurdleRace
    {
        public static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            // your code goes here

/*
INPUT
5 4
1 6 3 5 2
OUTPUT: 2

INPUT:
5 7
2 5 4 5 2
OUTPUT: 0
*/

            int count = 0;
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > k)
                {
                    var diff = height[i] - k;
                    count += diff;
                    if (diff > max)
                        max = diff;
                }
            }

            Console.WriteLine(max);
        }
    }
}
