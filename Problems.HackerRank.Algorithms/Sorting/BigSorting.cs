using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

/*
INPUT:
6
31415926535897932384626433832795
1
3
10
3
5
OUTPUT:
1
3
3
5
10
31415926535897932384626433832795
 */
namespace Problems.HackerRank.Algorithms.Sorting
{
	/// <summary>
	/// Big Sorting
	/// https://www.hackerrank.com/challenges/big-sorting	/// </summary>
	public class BigSorting
	{
		
		public static void Main()
		{
			// https://github.com/prasadtelkikar/HackerRank/blob/master/Algorithms/Arrays/BigSorting.cs
			//PrasadMethod();

			CustomSort();
		}

		private static void CustomSort()
		{
			int size = Convert.ToInt32(Console.ReadLine());
			string[] words = new string[size];
			for (int i = 0; i < size; i++)
			{
				words[i] = Console.ReadLine();
			}

			//Quicksort with O(nLog n) time complexity
			Array.Sort(words, new CustomComparer());

			StringBuilder buffer = new StringBuilder();
			foreach (string value in words)
			{
				buffer.AppendLine(value);
			}

			Console.WriteLine(buffer);
		}

		private static void PrasadMethod()
		{
			int size = Convert.ToInt32(Console.ReadLine());
			ulong[] uLArray = new ulong[size];
			BigInteger[] bInt = new BigInteger[size];
			for (int i = 0; i < size; i++)
			{
				bInt[i] = BigInteger.Parse(Console.ReadLine());
			}

			//Quicksort with O(nLog n) time complexity
			Array.Sort(bInt);

			StringBuilder buffer = new StringBuilder();
			foreach (BigInteger value in bInt)
			{
				buffer.AppendLine(value.ToString());
			}

			Console.WriteLine(buffer);
		}
	}

	internal class CustomComparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			// If the length is not the same, we return the difference.
			// A negative # means, x Length is shorter, 0 means the same (this doesn't occur) and a postive # means Y is bigger
			if (x.Length != y.Length) return x.Length - y.Length;

			// Now the length is the same.
			// Compare the number from the first digit.
			for (int i = 0; i < x.Length; i++)
			{
				char left = x[i];
				char right = y[i];
				if (left != right)
					return left - right;
			}

			// Default: "0" means both numbers are the same.
			return 0;
		}
	}
}
