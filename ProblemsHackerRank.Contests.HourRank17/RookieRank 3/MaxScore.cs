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
			BigInteger maxScore = GetMaxScore(a);
			Console.WriteLine(maxScore);
		}

		public static BigInteger GetMaxScore(long[] arr)
		{
			Queue<long> q = new Queue<long>(arr);
			var scores = new BigInteger[arr.Length];
			long runningSum = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				var a = q.Dequeue();
				scores[i] = new BigInteger(runningSum % a);
				runningSum += a;
			}

			return scores.Aggregate(0, (BigInteger acc, BigInteger next) => acc + next);
		}
	}
}
