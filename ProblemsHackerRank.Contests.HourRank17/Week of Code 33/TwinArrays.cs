using System;
using System.Linq;

/*
INPUT:
5
5 4 3 2 1
1 2 3 4 5
OUTPUT: 2
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_33
{
	public class TwinArrays
	{
		public static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] ar1_temp = Console.ReadLine().Split(' ');
			int[] ar1 = Array.ConvertAll(ar1_temp, Int32.Parse);
			string[] ar2_temp = Console.ReadLine().Split(' ');
			int[] ar2 = Array.ConvertAll(ar2_temp, Int32.Parse);
			int result = SumTwinArrays(ar1, ar2);
			Console.WriteLine(result);
		}

		public static int SumTwinArrays(int[] a1, int[] a2)
		{
			int min1 = a1.Min();
			int foundIndex = Array.FindIndex(a1, value => value == min1);

			int min2 = a2.Where((value, index) => index != foundIndex).Min();

			return min1 + min2;
		}
	}
}
