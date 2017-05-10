using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
10:19PM 02:49AM
08:49AM 09:10AM
OUTPUT:
Second
First
 */
namespace ProblemsHackerRank.Contests.RookieRank_3
{
	/// <summary>
	/// Comparing Times
	/// https://www.hackerrank.com/contests/rookierank-3/challenges/comparing-times
	/// </summary>
	public class ComparingTimes
	{
		public static void Main(String[] args)
		{
			int q = Convert.ToInt32(Console.ReadLine());
			var testCases = GetTestCases(q);
			List<string> result = GetTestCaseResult(testCases).ToList();
			result.ForEach(Console.WriteLine);
		}

		private static IEnumerable<string> GetTestCaseResult(IEnumerable<Tuple<string, string>> testCases)
		{
			foreach (Tuple<string, string> testCase in testCases)
			{
				yield return CompareTime(testCase.Item1, testCase.Item2);
			}
		}

		private static IEnumerable<Tuple<string, string>> GetTestCases(int q)
		{
			for (int i = 0; i < q; i++)
			{
				string[] tokens_t1 = Console.ReadLine().Split(' ');
				string t1 = tokens_t1[0];
				string t2 = tokens_t1[1];
				yield return Tuple.Create(t1, t2);
			}
		}

		public static string CompareTime(string t1, string t2)
		{
			DateTime dt1 = DateTime.Parse(t1);
			DateTime dt2 = DateTime.Parse(t2);

			TimeSpan diff = dt1.TimeOfDay - dt2.TimeOfDay;
			return diff.TotalMilliseconds < 0 ? "First" : "Second";
		}
	}
}
