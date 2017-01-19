using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Jumping on the Clouds
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds
    /// </summary>
    public class JumpingOnTheClouds
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

/*
input:
7
0 0 1 0 0 1 0
output: 4

Input:
6
0 0 0 0 1 0
output: 3 

Input:
6
0 0 0 1 0 0
output: 3
*/
            int steps = 0;
            const int isCloud = 1;
            const int largestStep = 2;
            for (int i = 0; i <= n - largestStep;)
            {
                if (i + largestStep > n - 1)
                {
                    steps++;
                    break;
                }

                if (c[i + largestStep] != isCloud)
                {
                    i += largestStep;
                }
                else
                {
                    i++;
                }
                steps++;
            }

            Console.WriteLine(steps);
        }
    }
}
