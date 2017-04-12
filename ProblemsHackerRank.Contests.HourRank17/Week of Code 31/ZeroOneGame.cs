using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
INPUT:
3
4
1 0 0 1
5
1 0 1 0 1
6
0 0 0 0 0 0
OUTPUT:
Bob
Alice
Bob
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_31
{
    /// <summary>
    /// Zero-One Game
    /// https://www.hackerrank.com/contests/w31/challenges/zero-one-game
    /// </summary>
    public class ZeroOneGame
    {
        public static void Main(String[] args)
        {
            int gameCount = Convert.ToInt32(Console.ReadLine());
            List<int[]> games = GetTestCases(gameCount).ToList();

            List<string> winners = GetWinners(games).ToList();
            winners.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> GetWinners(List<int[]> games)
        {
            foreach (int[] game in games)
            {
                yield return GetWinner(game);
            }
        }

        private static string GetWinner(int[] game)
        {
            int playCount = 0;
            var l = game.ToList();
            for (int i = 1; i < l.Count - 1; i++)
            {
                if (l.Count <= 2) break;

                var left = l[i - 1];
                var value = l[i];
                var right = l[i + 1];

                if (left == 0 && right == 0)
                {
                    l.RemoveAt(i);
                    playCount++;
                    i = 0;
                }
            }

            return playCount % 2 == 1 ? "Alice" : "Bob";
        }

        private static IEnumerable<int[]> GetTestCases(int testCaseCount)
        {
            for (int i = 0; i < testCaseCount; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] sequence_temp = Console.ReadLine().Split(' ');
                int[] sequence = Array.ConvertAll(sequence_temp, Int32.Parse);
                yield return sequence;
            }
        }
    }
}
