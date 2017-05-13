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

	/// <summary>
	/// https://www.coursera.org/learn/algorithms-part1/lecture/ZgecU/quick-union
	/// </summary>
	internal class QuickUnionUF
	{
		private readonly int[] _id;

		public QuickUnionUF(int n)
		{
			_id = new int[n];
			for (int i = 0; i < n; i++)
			{
				_id[i] = i;
			}
		}

		private int GetRoot(int i)
		{
			while (i != _id[i]) i = _id[i];
			return i;
		}

		public bool IsConnected(int p, int q)
		{
			return GetRoot(p) == GetRoot(q);
		}

		public void Union(int p, int q)
		{
			int i = GetRoot(p);
			int j = GetRoot(q);
			_id[i] = j;
		}
	}
}
