using System;
using System.Linq;

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
			int[][] routes = new int[m][];
			for (int i = 0; i < m; i++)
			{
				string[] tempRoute = Console.ReadLine().Split(' ');
				routes[i] = Array.ConvertAll(tempRoute, int.Parse);
			}

			int count = GetMaximumTourism(n, routes);
			Console.WriteLine(count);
		}

		private static int GetMaximumTourism(int n, int[][] routes)
		{
			QuickUnionUF uf = GetQuickUnion(n, routes);
			return uf.GetMaximumConnectedRoute();
		}

		private static QuickUnionUF GetQuickUnion(int n, int[][] routes)
		{
			QuickUnionUF uf = new QuickUnionUF(n);

			foreach (int[] route in routes)
			{
				int p = route[0];
				int q = route[1];
				uf.Union(p, q);
			}

			return uf;
		}
	}

	/// <summary>
	/// https://www.coursera.org/learn/algorithms-part1/lecture/ZgecU/quick-union
	/// then improved using
	/// https://www.coursera.org/learn/algorithms-part1/lecture/RZW72/quick-union-improvements
	/// </summary>
	internal class QuickUnionUF
	{
		private readonly int[] _id;
		private readonly int[] _size;

		public QuickUnionUF(int n)
		{
			_id = new int[n + 1];
			_size = new int[n + 1];
			for (int i = 0; i < n; i++)
			{
				_id[i] = i;
				_size[i] = 1;
			}
		}

		private int GetRoot(int i)
		{
			while (i != _id[i])
				i = _id[i];
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
			if (i == j) return;
			if (_size[i] < _size[j])
			{
				_id[i] = j;
				_size[j] += _size[i];
			}
			else
			{
				_id[j] = i;
				_size[i] += _size[j];
			}
		}

		public int GetMaximumConnectedRoute()
		{
			return _size.Max();
		}
	}
}
