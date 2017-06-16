using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
INPUT:
3
100001abc101
1001ab010abc01001
1001010001
OUTPUT:
2
2
3
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_33
{
	public class PatternCount
	{
		public static void Main(String[] args)
		{
			int q = Convert.ToInt32(Console.ReadLine());

			List<int> counts = new List<int>(q);
			for (int a0 = 0; a0 < q; a0++)
			{
				string s = Console.ReadLine();
				counts.Add(GetPatternCount(s));
			}

			counts.ForEach(Console.WriteLine);
		}

		public static int GetPatternCount(string text)
		{
			// Using RegEx Look Behind.
			const string pattern = @"(?<=1)(0+)1";
			return Regex.Matches(text, pattern, RegexOptions.Singleline).Count;
		}
	}
}
