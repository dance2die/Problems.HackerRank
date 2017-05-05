using System;
using System.Linq;

/*
INPUT: 2017
OUTPUT: 13.09.2017

INPUT: 2016
OUTPUT: 12.09.2016
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
	/// <summary>
	/// Day of the Programmer
	/// https://www.hackerrank.com/challenges/day-of-the-programmer
	/// </summary>
	public class DayOfTheProgrammer
	{
		public static void Main(string[] args)
		{
			int year = Convert.ToInt32(Console.ReadLine());
			string result = Solve(year);
			Console.WriteLine(result);
		}

		private static string Solve(int year)
		{
			int[] sevenMonths = {31, 31, 30, 31, 30, 31, 31};
			int februaryDays = GetFebruaryDays(year);

			int sum = sevenMonths.Sum() + februaryDays;
			int daysLeft = 256 - sum;

			return $"{daysLeft}.09.{year}";
		}

		private static int GetFebruaryDays(int year)
		{
			if (IsLeapYear(year))
				return 29;
			return 28;
		}

		private static bool IsLeapYear(int year)
		{
			if (year % 400 == 0) return true;
			if (year % 100 == 0) return false;
			if (year % 4 == 0) return true;

			return false;
		}
	}
}
