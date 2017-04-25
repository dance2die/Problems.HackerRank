using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
INPUT:
abccddde
6
1
3
12
5
9
10
OUTPUT:
Yes
Yes
Yes
Yes
No
No
 */
namespace Problems.HackerRank.Algorithms.Strings
{
	/// <summary>
	/// Weighted Uniform Strings
	/// https://www.hackerrank.com/challenges/weighted-uniform-string
	/// </summary>
	public class WeightedUniformStrings
	{
		public static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int n = Convert.ToInt32(Console.ReadLine());
			IEnumerable<int> queries = GetQueries(n);
			List<string> answers = GetQueryAnswers(text, queries).ToList();

			answers.ForEach(Console.WriteLine);
		}

		private static IEnumerable<string> GetQueryAnswers(string text, IEnumerable<int> queries)
		{
			HashSet<int> weightMap = GetTextWeightMap(text);

			foreach (int query in queries)
			{
				yield return GetQueryAnswer(weightMap, query);
			}
		}

		private static string GetQueryAnswer(HashSet<int> weightMap, int query)
		{
			return weightMap.Contains(query) ? "Yes" : "No";
		}

		private static HashSet<int> GetTextWeightMap(string text)
		{
			var result = new HashSet<int>();
			var previousValue = "";
			var buffer = new StringBuilder();

			foreach (string currentValue in text.Select(c => c.ToString()))
			{
				if (currentValue == previousValue)
					buffer.Append(currentValue);
				else
					buffer = new StringBuilder(currentValue);

				result.Add(GetTextWeight(buffer.ToString()));

				previousValue = currentValue;
			}

			return result;
		}

		private static int GetTextWeight(string text)
		{
			int sum = 0;

			foreach (char c in text)
			{
				sum += GetCharacterWeight(c);
			}

			return sum;
		}

		private static int GetCharacterWeight(char c)
		{
			int asciiOffset = 96;
			return c - asciiOffset;
		}

		private static IEnumerable<int> GetQueries(int n)
		{
			for (int i = 0; i < n; i++)
			{
				yield return Convert.ToInt32(Console.ReadLine());
			}
		}
	}
}
