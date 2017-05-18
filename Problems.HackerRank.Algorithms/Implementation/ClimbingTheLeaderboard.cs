using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
7
100 100 50 40 40 20 10
4
5 25 50 120
OUTPUT:
6
4
2
1
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
	public class ClimbingTheLeaderboard
	{
		public static void Main()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] scores_temp = Console.ReadLine().Split(' ');
			int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
			int m = Convert.ToInt32(Console.ReadLine());
			string[] alice_temp = Console.ReadLine().Split(' ');
			int[] alicesScores = Array.ConvertAll(alice_temp, Int32.Parse);

			List<int> ranks = GetAlicesRanks(scores, alicesScores).ToList();
			ranks.ForEach(Console.WriteLine);
		}

		private static IEnumerable<int> GetAlicesRanks(int[] scores, int[] alicesScores)
		{
			foreach (var alicesScore in alicesScores)
			{
				yield return GetRank2(scores, alicesScore);
			}
		}

		private static int GetRank2(int[] scores, int alicesScore)
		{
			// Aggregate scores.
			List<int> allScores = new List<int>(scores.Distinct()) { alicesScore };
			var rank = allScores.OrderByDescending(a => a).ToList().FindIndex(a => a == alicesScore) + 1;
			return rank;
		}

		private static int GetRank(int[] scores, int alicesScore)
		{
			// Aggregate scores.
			List<int> allScores = new List<int>(scores) {alicesScore};

			var scoreCounts = allScores.GroupBy(val => val).Select(group => new
			{
				Score = group.Key,
				Count = group.Count()
			}).OrderByDescending(grouped => grouped.Score);

			int rank = 0;
			int prevScore = int.MinValue;
			foreach (var scoreCount in scoreCounts)
			{
				if (prevScore != scoreCount.Count)
					rank++;

				if (scoreCount.Score == alicesScore)
					return rank;

				prevScore = scoreCount.Score;
			}

			return rank;
		}
	}
}
