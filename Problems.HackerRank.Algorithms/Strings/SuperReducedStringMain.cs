using System;
using System.Collections.Generic;

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

            string output = input;
            var index = 0;
            while (RemoveAdjacentPair(ref output, index))
            {
                index++;
            }

            var result = string.IsNullOrWhiteSpace(output) ? "Empty String" : output;
            Console.WriteLine(result);
        }

        /// <summary>
        /// Returns true if any adjancet pair has been removed.
        /// </summary>
        private static bool RemoveAdjacentPair(ref string input, int index)
        {
            List<char> tempResult = new List<char>();
            for (int i = index; i < input.Length; i++)
            {
                var realBound = i + 1;
                if (realBound < input.Length)
                {
                    //tempResult.Add(input[i]);
                    if (input[i] == input[realBound])
                    {
                        tempResult.AddRange(input.Substring(realBound));
                        input = new string(tempResult.ToArray());
                        return true;
                    }
                }
                else
                {
                    index = 0;
                }
            }

            return false;
        }
    }
}
