using System;
using System.Collections.Generic;
using System.Linq;

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
            List<char> alreadyChecked = new List<char>();

            int maxCount = 0;
            foreach (char c in text)
            {
                if (alreadyChecked.Contains(c)) continue;

                var alternatingCharacterCount = GetAlternatingCharacterCount(text, c);
                if (alternatingCharacterCount > maxCount)
                    maxCount = alternatingCharacterCount;
            }

            return maxCount;
        }

        private static int GetAlternatingCharacterCount(string text, char c)
        {
            int result = int.MinValue;
            var filteredText = new string(text.Where(c1 => c1 != c).ToArray());

            if (IsAlternating(filteredText))
                return filteredText.Length;
            return result;;
        }

        private static bool IsAlternating(string text)
        {
            return false;
        }
    }
}
