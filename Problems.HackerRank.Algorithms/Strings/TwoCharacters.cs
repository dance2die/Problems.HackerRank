using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            foreach (char c1 in text)
            {
                foreach (var c2 in text.Where(c => c != c1))
                {
                    if (alreadyChecked.Contains(c1)) continue;

                    var alternatingCharacterCount = GetAlternatingCharacterCount(text, c1, c2);
                    if (alternatingCharacterCount > maxCount)
                        maxCount = alternatingCharacterCount;
                }
            }

            return maxCount;
        }

        private static int GetAlternatingCharacterCount(string text, char c1, char c2)
        {
            int result = int.MinValue;
            var charsToRemove = text.Where(c => c != c1 && c != c2);

            int max = 0;
            List<char> removedChars = new List<char>();
            foreach (var removeChar in charsToRemove)
            {
                removedChars.Add(removeChar);
                var filteredText = new string(text.Where(c => removedChars.Contains(c)).ToArray());
                if (IsAlternating(filteredText) && filteredText.Length > max)
                    max = filteredText.Length;
            }

            return max;
        }

        private static bool IsAlternating(string text)
        {
            Debug.Assert(text.Length >= 1);
            if (text.Length == 1) return true;

            char c1 = text[0];
            char c2 = text[1];
            if (c1 == c2) return false;

            for (int i = 2; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (text[i] != c1) return false;
                }
                else
                {
                    if (text[i] != c2) return false;
                }
            }

            return true;
        }
    }
}
