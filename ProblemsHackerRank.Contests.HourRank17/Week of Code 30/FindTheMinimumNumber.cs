using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
INPUT: 2
OUTPUT: min(int, int)

INPUT: 4
OUTPUT: min(int, min(int, min(int, int)))
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_30
{
    /// <summary>
    /// Find the Minimum Number
    /// https://www.hackerrank.com/contests/w30/challenges/find-the-minimum-number
    /// </summary>
    public class FindTheMinimumNumber
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string result = GetMinText(n);
            Console.WriteLine(result);
        }

        private static string GetMinText(int n)
        {
            const string minimum = "min(int, int)";
            if (n <= 2) return minimum;

            const string prefix = "min(int, ";
            const string postfix = ")";

            string buffer = minimum;
            for (int i = 0 ; i < n - 2; i++)
            {
                buffer = $"{prefix}{buffer}{postfix}";
            }

            return buffer;
        }
    }
}
