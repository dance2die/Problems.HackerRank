using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

/*
INPUT:
3
4 8 5
OUTPUT: 6

INPUT: test case #1
4
107493882593281 9436949668167681 2227744075153409 4692795778924545
OUTPUT:9470765577011206

INPUT: test case #2
6
8786531805757441 230677884929 1817524031489 7781447890698241 25646965377 1845642452993
OUTPUT: 7791384336505984

INPUT: #3
10
3741039095644161 129755978241 640424193025 2187964615950337 8146770730811393 1121690921598977 126749818497 9702157959364609 4058290446925825 2964749385465857
OUTPUT: 26340064033781408
 */
namespace ProblemsHackerRank.Contests.RookieRank_3
{
	public class MaxScore
	{
		public static void Main()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] a_temp = Console.ReadLine().Split(' ');
			long[] a = Array.ConvertAll(a_temp, Int64.Parse);
			BigInteger maxScore = GetMaxScoreForAllPermutations(a);
			Console.WriteLine(maxScore);
		}

		public static BigInteger GetMaxScoreForAllPermutations(long[] arr)
		{
			var perms = GetPermutations(arr, 0, arr.Length - 1);

			long maxScore = 0;
			foreach (IEnumerable<long> longs in perms)
			{
				var perm = longs.ToArray();
				long score = GetMaxScore(perm);
				if (score > maxScore)
					maxScore = score;
			}

			return maxScore;
		}

		private static IEnumerable<IEnumerable<T>> GetPermutations<T>(IList<T> list, int startIndex, int permutationCount)
		{
			if (startIndex == permutationCount)
			{
				yield return list;
			}
			else
			{
				for (int i = startIndex; i <= permutationCount; i++)
				{
					Swap(list, startIndex, i);

					List<T> listCopy = list.ToList();
					foreach (IEnumerable<T> permutation in GetPermutations(listCopy, startIndex + 1, permutationCount))
					{
						yield return permutation;
					}
				}
			}
		}

		private static void Swap<T>(IList<T> list, int index1, int index2)
		{
			var temp = list[index1];
			list[index1] = list[index2];
			list[index2] = temp;
		}

		private static long GetMaxScore(long[] arr)
		{
			var scores = new long[arr.Length];
			long runningSum = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				var a = arr[i];
				scores[i] = runningSum % a;
				runningSum += a;
			}

			return scores.Sum();

		}
	}
}
