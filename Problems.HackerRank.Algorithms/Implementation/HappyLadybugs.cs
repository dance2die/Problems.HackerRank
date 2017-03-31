using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
4
7
RBY_YBR
6
X_Y__X
2
__
6
B_RRBR
OUTPUT:
YES
NO
YES
YES
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Happy Ladybugs
    /// https://www.hackerrank.com/challenges/happy-ladybugs
    /// </summary>
    public class HappyLadybugs
    {
        public static void Main()
        {
            int caseCount = int.Parse(Console.ReadLine());
            List<string> games = GetGames(caseCount).ToList();
        }

        private static IEnumerable<string> GetGames(int caseCount)
        {
            for (int i = 0; i < caseCount; i++)
            {
                Console.ReadLine();    // ignore length of the board
                yield return Console.ReadLine();
            }
        }
    }
}
