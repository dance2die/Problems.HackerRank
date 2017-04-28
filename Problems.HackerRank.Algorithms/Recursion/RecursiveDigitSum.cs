using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
INPUT:
148 3
OUTPUT: 3
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
			
		}

        /// <summary>
        /// https://www.slightedgecoder.com/2017/03/11/parsing-number-digits/
        /// </summary>
        private static List<int> GetDigits(int val)
        {
            Stack<int> stack = new Stack<int>();

            int number = val;
            while (number > 0)
            {
                var digit = number % 10;
                stack.Push(digit);

                number /= 10;
            }

            return stack.ToList();
        }
    }
}
