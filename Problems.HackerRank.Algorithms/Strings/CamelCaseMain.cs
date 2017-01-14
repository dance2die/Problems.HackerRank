using System;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// CamelCase
    /// https://www.hackerrank.com/challenges/camelcase?h_r=next-challenge&h_v=zen
    /// </summary>
    public class CamelCaseMain
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // input = "saveChangesInTheEditor";
            // output = 5

            // Edge case check.
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(0);
                return;
            }

            // First letter always starts with lower case
            int count = 1;
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
