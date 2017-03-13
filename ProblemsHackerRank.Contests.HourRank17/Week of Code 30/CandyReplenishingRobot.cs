using System;

/*
INPUT:
8 3
5 2 4
OUTPUT: 5
 
INPUT:
8 4
3 1 7 5
OUTPUT: 11
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_30
{
    /// <summary>
    /// Candy Replenishing Robot
    /// https://www.hackerrank.com/contests/w30/challenges/candy-replenishing-robot
    /// </summary>
    public class CandyReplenishingRobot
    {
        private const int THREASHOLD = 5;

        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(temp, int.Parse);

            int candieCount = GetReplenishedCandieCount(n, t, c);
            Console.WriteLine(candieCount);
        }

        private static int GetReplenishedCandieCount(int totalCandie, int minutes, int[] takeAways)
        {
            int candieCountInBowl = totalCandie;
            int candiesAdded = 0;

            for (int i = 0; i < minutes - 1; i++)
            {
                candieCountInBowl -= takeAways[i];
                if (candieCountInBowl < THREASHOLD)
                {
                    int candieToAdd = totalCandie - candieCountInBowl;
                    candiesAdded += candieToAdd;

                    candieCountInBowl = totalCandie;
                }
            }

            return candiesAdded;
        }
    }
}
