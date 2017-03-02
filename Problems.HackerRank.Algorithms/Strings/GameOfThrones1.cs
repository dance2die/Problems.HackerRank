using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT: aaabbbb
OUTPUT: YES

INPUT: cdefghmnopqrstuvw
OUTPUT: NO

INPUT: cdcdcdcdeeeef
OUTPUT: YES
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Game of Thrones - I
    /// https://www.hackerrank.com/challenges/game-of-thrones
    /// </summary>
    public class GameOfThrones1
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string hasPalindromePermutation = GetHasPalindromePermutation(input);
            Console.WriteLine(hasPalindromePermutation);
        }

        private static string GetHasPalindromePermutation(string input)
        {
            Dictionary<char, int> map = GetCharacterSetMap(input);

            // If less than or equal to one odd value exists, then "YES" else "NO"
            if (map.Count(pair => pair.Value % 2 == 1) <= 1)
                return "YES";
            return "NO";
        }

        private static Dictionary<char, int> GetCharacterSetMap(string input)
        {
            Dictionary<char, int> result = new Dictionary<char, int>(input.Distinct().Count());

            foreach (char c in input)
            {
                if (!result.ContainsKey(c))
                    result.Add(c, 0);
                result[c]++;
            }

            return result;
        }
    }
}
