using System;
using System.Collections.Generic;
using System.Linq;

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
			Dictionary<string, int> weightMap = GetTextWeightMap(text);

			foreach (int query in queries)
			{
				yield return GetQueryAnswer(weightMap, query);
			}
		}

		private static Dictionary<string, int> GetTextWeightMap(string text)
		{
			Dictionary<string, int> result = new Dictionary<string, int>();
			string prev = "";
			string curr = "";

			foreach (string c in text.Select(c => c.ToString()))
			{
				if (c == prev)
					curr += c;
				else
					curr = c;

				if (!result.ContainsKey(curr))
					result.Add(curr, GetTextWeight(curr));

				prev = c;
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

		private static string GetQueryAnswer(Dictionary<string, int> weightMap, int query)
		{
			return weightMap.ContainsValue(query) ? "Yes" : "No";
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
