using System;
using System.Collections.Generic;

/*
INPUT: batman
OUTPUT: Yes

INPUT: apple
OUTPUT: No

INPUT: beauty
OUTPUT: No

INPUT: abacaba
OUTPUT: Yes

INPUT: badd
OUTPUT: No

INPUT: yes
OUTPUT: No
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_31
{
    /// <summary>
    /// Beautiful Word
    /// https://www.hackerrank.com/contests/w31/challenges/beautiful-word
    /// </summary>
    public class BeautifulWord
    {
        public static void Main(string[] args)
        {
            string w = Console.ReadLine();

            bool isBeautifulWord = IsBeautifulWord(w);
            Console.WriteLine(isBeautifulWord ? "Yes" : "No");
        }

        private static readonly HashSet<char> _vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y' };

        private static bool IsBeautifulWord(string w)
        {
            for (int i = 0; i < w.Length - 1; i++)
            {
                char c = w[i];
                char next = w[i + 1];

                if (IsVowel(c))
                {
                    if (_vowels.Contains(next)) return false;
                }
                else  // is Consonant
                {
                    if (c == next) return false;
                }
            }
            
            return true;
        }

        private static bool IsVowel(char c)
        {
            return _vowels.Contains(c);
        }
    }
}
