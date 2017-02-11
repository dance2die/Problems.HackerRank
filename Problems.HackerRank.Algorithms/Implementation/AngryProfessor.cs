using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
4 3
-1 -3 4 2
4 2
0 -1 2 1
OUPUT:
YES
NO
 */

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Angry Professor
    /// https://www.hackerrank.com/challenges/angry-professor
    /// </summary>
    public class AngryProfessor
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<string> answers = new List<string>(t);

            for (int i = 0; i < t; i++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int threadshold = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, int.Parse);

                answers.Add(GetAnswerForThreashold(threadshold, a));
            }

            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }

        private static string GetAnswerForThreashold(int threadshold, int[] a)
        {
            int earlyCount = a.Count(value => value <= 0);
            if (earlyCount < threadshold)
                return "YES";
            return "NO";
        }
    }
}
