using System;

namespace ProblemsHackerRank.Contests.RookieRank
{
    /// <summary>
    /// Counting Valleys
    /// https://www.hackerrank.com/contests/rookierank/challenges/counting-valleys
    /// </summary>
    public class CountingValleys
    {
        public static void Main()
        {
            int stepCount = int.Parse(Console.ReadLine());
            string steps = Console.ReadLine();

/*
INPUT:
8
UDDDUDUU
OUTPUT: 1
*/

            int valleyCount = GetValleyCount(steps);
            Console.WriteLine(valleyCount);
        }

        private static int GetValleyCount(string steps)
        {
            int valleyCount = 0;
            int currentLevel = 0;
            foreach (char step in steps)
            {
                int previousLevel = currentLevel;

                if (step == 'U')
                    currentLevel++;
                else
                    currentLevel--;

                if (previousLevel < 0 && currentLevel == 0)
                    valleyCount++;
            }

            return valleyCount;
        }
    }
}
