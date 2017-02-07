using System;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Two Characters
    /// https://www.hackerrank.com/challenges/two-characters
    /// </summary>
    public class TwoCharacters
    {
        public static void Main(String[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string text = Console.ReadLine();
/*
INPUT:
10
beabeefeab
OUTPUT: 5
*/

            int result = GetLongestSequence(text);
            Console.WriteLine(result);
        }

        private static int GetLongestSequence(string text)
        {
            return -1;
        }
    }
}
