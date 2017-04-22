using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
hereiamstackerrank
hackerworld
OUTPUT:
YES
NO
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// HackerRank in a String
    /// https://www.hackerrank.com/challenges/hackerrank-in-a-string
    /// </summary>
    public class HackerRankInAString
    {
        public static void Main()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            var texts = GetTexts(q);
            List<string> answers = HasHackerRankInTexts(texts).ToList();
            answers.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> HasHackerRankInTexts(IEnumerable<string> texts)
        {
            foreach (string text in texts)
            {
                yield return HasHackerRankInText(text);
            }
        }

        private static string HasHackerRankInText(string text)
        {
            Queue<char> hackerrank = new Queue<char>("hackerrank".ToCharArray());
            foreach (char c in text)
            {
                if (c == hackerrank.Peek())
                    hackerrank.Dequeue();

                if (hackerrank.Count == 0)
                    return "YES";
            }

            return "NO";
        }

        private static IEnumerable<string> GetTexts(int q)
        {
            for (int i = 0; i < q; i++)
            {
                yield return Console.ReadLine();
            }
        }
    }
}
