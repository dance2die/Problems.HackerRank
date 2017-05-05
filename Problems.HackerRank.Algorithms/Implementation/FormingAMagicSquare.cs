using System;

/*
INPUT: test case #2
4 5 8
2 4 1
1 9 7
OUTPUT: 14
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
	/// <summary>
	/// Forming a Magic Square
	/// https://www.hackerrank.com/challenges/magic-square-forming
	/// </summary>
	public class FormingAMagicSquare
	{
		public static void Main(string[] args)
		{
			int[][] s = new int[3][];
			for (int i = 0; i < 3; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				s[i] = Array.ConvertAll(line, int.Parse);
			}
			//  Print the minimum cost of converting 's' into a magic square
			int cost = GetCost(s);
			Console.WriteLine(cost);
		}

		private static int GetCost(int[][] matrix)
		{
			//int[][] validMatrix =
			//{
			//	new[] {4, 9, 2}, new[] {3, 5, 7}, new[] {8, 1, 6},
			//};
			int[][][] validMatrix =
			{
				new [] { new[] {8, 1, 6}, new[] {3, 5, 7}, new[] {4, 9, 2} },
				new [] { new[] {6, 1, 8}, new[] {7, 5, 3}, new[] {2, 9, 4} },
				new [] { new[] {8, 3, 4}, new[] {1, 5, 9}, new[] {6, 7, 2} },
				new [] { new[] {4, 3, 8}, new[] {9, 5, 1}, new[] {2, 7, 6} },
				new [] { new[] {6, 7, 2}, new[] {1, 5, 9}, new[] {8, 3, 4} },
				new [] { new[] {2, 7, 6}, new[] {9, 5, 1}, new[] {4, 3, 8} },
				new [] { new[] {4, 9, 2}, new[] {3, 5, 7}, new[] {8, 1, 6} },
				new [] { new[] {2, 9, 4}, new[] {7, 5, 3}, new[] {6, 1, 8} },
			};

			int minCost = int.MaxValue;
			for (int i = 0; i < validMatrix.Length; i++)
			{
				int cost = 0;
				for (int j = 0; j < validMatrix[i].Length; j++)
				{
					for (int k = 0; k < validMatrix[i][j].Length; k++)
					{
						cost += Math.Abs(matrix[j][k] - validMatrix[i][j][k]);
					}
				}
				if (cost < minCost)
					minCost = cost;
			}

			return minCost;
		}
	}
}
