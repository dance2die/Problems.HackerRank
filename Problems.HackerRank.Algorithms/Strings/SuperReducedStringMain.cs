using System;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/reduced-string
    /// </summary>
    public class Solution
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //Console.WriteLine(input);
            //string input = "aaabccddd";
            // output: abd
            // input: mwkommokwmxjivkkvijxshscbbcshsgwdyqqydwgzpnlzzlnpzvfeaiiaefvyeqjccjqeymhqhiihqhmhaomkkmoahhddymmyddh
            // output: Empty String

            const int removeSize = 2;
            for (int i = 0; HasSameAdjacentLetter(input); i++)
            {
                if (i + 1 >= input.Length)
                {
                    i = -1;
                    continue;
                }

                if (input[i] == input[i + 1])
                {
                    input = input.Remove(i, removeSize);
                }
            }

            Console.WriteLine(string.IsNullOrWhiteSpace(input) ? "Empty String" : input);
        }

        private static bool HasSameAdjacentLetter(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1]) return true;
            }

            return false;
        }
    }
}
