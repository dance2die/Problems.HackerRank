/*
INPUT:
4
aba
baba
aba
xzxb
3
aba
xzxb
ab
OUTPUT:
2
1
0
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.DataStructure.Arrays
{
    /// <summary>
    /// Sparse Arrays
    /// https://www.hackerrank.com/challenges/sparse-arrays
    /// </summary>
    public class SparseArrays
    {
        public static void Main()
        {
            int textCount = int.Parse(Console.ReadLine());
            List<string> texts = GetTexts(textCount).ToList();
            int queryCount = int.Parse(Console.ReadLine());
            List<string> queries = GetTexts(queryCount).ToList();

            IEnumerable<int> output = GetOutput2(texts, queries);
            PrintOutput(output);
        }

        private static IEnumerable<int> GetOutput2(List<string> texts, List<string> queries)
        {
            foreach (string query in queries)
            {
                yield return texts.Count(text => text == query);
            }
        }

        private static IEnumerable<int> GetOutput(List<string> texts, List<string> queries)
        {
            Dictionary<string, int> textMap = GetTextMap(texts);
            foreach (string query in queries)
            {
                if (textMap.ContainsKey(query))
                    yield return textMap[query];
                else
                    yield return 0;
            }
        }

        private static Dictionary<string, int> GetTextMap(List<string> texts)
        {
            Dictionary<string, int> result = new Dictionary<string, int>(texts.Count);

            foreach (string text in texts)
            {
                if (result.ContainsKey(text))
                    result[text]++;
                else
                    result.Add(text, 1);
            }

            return result;
        }

        private static void PrintOutput(IEnumerable<int> output)
        {
            foreach (int value in output)
            {
                Console.WriteLine(value);
            }
        }

        private static IEnumerable<string> GetTexts(int textCount)
        {
            for (int i = 0; i < textCount; i++)
            {
                yield return Console.ReadLine();
            }
        }
    }
}
