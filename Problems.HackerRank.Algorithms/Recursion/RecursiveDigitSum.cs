using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

/*
INPUT:
148 3
OUTPUT: 3

INPUT:
593 10
OUTPUT: 8
 */
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
		    int n = int.Parse(inputs[0]);
		    int k = int.Parse(inputs[1]);

		    BigInteger p = GetComputeDigit(n, k);
            BigInteger superDigit = GetSuperDigit(p);

		    Console.WriteLine(superDigit);
		}

	    private static BigInteger GetSuperDigit(BigInteger p)
	    {
	        var digits = GetDigits(p);
	        while (digits.Count > 1)
	        {
	            var sum = digits.Aggregate<BigInteger, BigInteger>(0, (total, next) => total + next);
                digits = GetDigits(sum);
            }

	        return digits[0];
	    }

	    private static BigInteger GetComputeDigit(int n, int k)
	    {
	        string value = string.Join("", Enumerable.Repeat(n.ToString(), k));
	        return BigInteger.Parse(value);
	    }

	    /// <summary>
        /// https://www.slightedgecoder.com/2017/03/11/parsing-number-digits/
        /// </summary>
        private static List<BigInteger> GetDigits(BigInteger val)
        {
            var stack = new Stack<BigInteger>();

            BigInteger number = val;
            while (number > 0)
            {
                BigInteger digit = number % 10;
                stack.Push(digit);

                number /= 10;
            }

            return stack.ToList();
        }
    }
}
