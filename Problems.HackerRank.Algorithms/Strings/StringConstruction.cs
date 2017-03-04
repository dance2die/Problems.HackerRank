using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
abcd
abab
OUTPUT:
4
2
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// String Construction
    /// https://www.hackerrank.com/challenges/string-construction
    /// </summary>
    public class StringConstruction
    {
        public static void Main()
        {
            var lines = Enumerable.Range(0, int.Parse(Console.ReadLine()))
                .Select(_ => Console.ReadLine()).ToList();
            var costs = GetCosts(lines).ToList();

            PrintCosts(costs);
        }

        private static int GetCost(string line)
        {
            HashSet<char> map = new HashSet<char>();
            int totalCost = 0;

            foreach (char c in line)
            {
                if (!map.Contains(c))
                {
                    map.Add(c);
                    totalCost++;
                }
            }

            return totalCost;
        }

        private static IEnumerable<int> GetCosts(List<string> lines)
        {
            foreach (var line in lines)
            {
                yield return GetCost(line);
            }
        }

        private static void PrintCosts(List<int> costs)
        {
            costs.ForEach(Console.WriteLine);
        }
    }
}
