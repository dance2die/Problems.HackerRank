using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			int[][] validMatrix =
			{
				new[] {4, 9, 2},
				new[] {3, 5, 7},
				new[] {8, 1, 6},
			};

			int cost = 0;
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					cost += Math.Abs(matrix[i][j] - validMatrix[i][j]);
				}
			}

			return cost;
		}
	}
}
