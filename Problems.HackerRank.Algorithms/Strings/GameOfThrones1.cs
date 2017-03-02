using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // if all of charactersets have even number then "YES".
            // if all BUT one charactersets have even number then "YES".
            // else "NO"

            return "NO";
        }
    }
}
