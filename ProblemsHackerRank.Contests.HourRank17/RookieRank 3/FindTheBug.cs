using System;

/*
INPUT:
5
OOOOO
OXOOO
OOOOO
OOOOO
OOOOO
OUTPUT:
1,1
 */
namespace ProblemsHackerRank.Contests.RookieRank_3
{
	/// <summary>
	/// Find the Bug
	/// https://www.hackerrank.com/contests/rookierank-3/challenges/find-the-bug
	/// </summary>
	public class FindTheBug
	{
		public static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] grid = new string[n];
			for (int i = 0; i < n; i++)
			{
				grid[i] = Console.ReadLine();
			}
			// Return an array containing [r, c]
			int[] result = Find(grid);
			Console.WriteLine(String.Join(",", result));
		}

		public static int[] Find(string[] grid)
		{
			for (int i = 0; i < grid.Length; i++)
			{
				int index = grid[i].IndexOf("X");
				if (index > 0)
					return new[] {i, index};
			}
			return new int[] { };
		}
	}
}
