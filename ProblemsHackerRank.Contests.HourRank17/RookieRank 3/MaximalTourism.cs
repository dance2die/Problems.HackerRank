using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
INPUT:
8 5
1 2
7 4
7 3
5 8
1 3
OUTPUT: 5
 */
namespace ProblemsHackerRank.Contests.RookieRank_3
{
	/// <summary>
	/// Maximal Tourism
	/// https://www.hackerrank.com/contests/rookierank-3/challenges/maximal-tourism
	/// </summary>
	/// <remarks>
	/// Refer to video Cousera video course https://www.coursera.org/learn/algorithms-part1/lecture/ZgecU/quick-union
	/// </remarks>
	public class MaximalTourism
	{
		public static void Main()
		{
			string[] tokens = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens[0]);
			int m = Convert.ToInt32(tokens[1]);
			int[][] route = new int[m][];
			for (int i = 0; i < m; i++)
			{
				string[] tempRoute = Console.ReadLine().Split(' ');
				route[i] = Array.ConvertAll(tempRoute, int.Parse);
			}

			int count = GetMaximumTourism(n, route);
			Console.WriteLine(count);
		}

		private static int GetMaximumTourism(int n, int[][] route)
		{
			
		}
	}
}
