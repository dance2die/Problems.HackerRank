using System;
using System.Linq;

/*
INPUT:
148 3
OUTPUT: 3

INPUT:
593 10
OUTPUT: 8

INPUT:
861568688536788 100000
OUTPUT: 3

 *  */
namespace Problems.HackerRank.Algorithms.Recursion
{
	/// <summary>
	/// Recursive Digit Sum
	/// https://www.hackerrank.com/challenges/recursive-digit-sum
	/// </summary>
	public class RecursiveDigitSum
	{
		public static void Main(string[] args)
		{
            var inputs = Console.ReadLine().Split(' ');
            var n = inputs[0];
            var k = int.Parse(inputs[1]);

            //string p = GetComputeDigit(n, k);
            var superDigit = GetSuperDigit((GetSum(n) * k).ToString());

            Console.WriteLine(superDigit);
            //Console.WriteLine(super_digit((digit_sum(n) * k).ToString()));
        }

        private static string GetSuperDigit(string p)
        {
            if (p.Length == 1)
                return p;
            return GetSuperDigit(GetSum(p).ToString());
        }

	    private static long GetSum(string text)
	    {
	        long sum = 0;
	        for (var i = 0; i < text.Length; i++)
	        {
	            sum += text[i] - '0';
	        }
	        return sum;
;	    }

	    //private static string GetComputeDigit(string n, int k)
	    //{
	    //    //return string.Join("", Enumerable.Repeat(n, k));
	    //}
    }
}
