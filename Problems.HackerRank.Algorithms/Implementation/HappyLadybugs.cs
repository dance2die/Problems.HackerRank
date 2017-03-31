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

            List<string> result = AreGamesPlayable(games).ToList();
            result.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> AreGamesPlayable(List<string> games)
        {
            foreach (string game in games)
            {
                yield return IsGamePlayable(game) ? "YES" : "NO";
            }
        }

        private static bool IsGamePlayable(string game)
        {
            // edge cases
            // if only empty spaces, then true
            if ("_" == new string(game.Distinct().ToArray())) return true;

            // if there is a letter with only one instance, then no.
            var hasOneInstance = game.ToCharArray().Where(c => c != '_').GroupBy(c => c).Select(g => g.Count()).Any(count => count == 1);
            if (hasOneInstance) return false;

            return true;
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
