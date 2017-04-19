using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
6
1 4 4 4 5 3
OUTPUT: 4

INPUT:
8
1 2 2 2 3 3 3 4
OUTPUT: 2
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Migratory Birds
    /// https://www.hackerrank.com/challenges/migratory-birds
    /// </summary>
    public class MigratoryBirds
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] types_temp = Console.ReadLine().Split(' ');
            int[] types = Array.ConvertAll(types_temp, Int32.Parse);
            // your code goes here

            int mostCommonBirdCount = GetMostCommonBirdCount2(types);
            Console.WriteLine(mostCommonBirdCount);
        }

        private static int GetMostCommonBirdCount2(int[] types)
        {
            Dictionary<int, int> typeMap = new Dictionary<int, int>
            {
                {1, 0},{2, 0},{3, 0},{4, 0},{5, 0}
            };

            foreach (int type in types)
            {
                typeMap[type]++;
            }

            int max = typeMap.Max(pair => pair.Value);
            foreach (KeyValuePair<int, int> pair in typeMap)
            {
                if (pair.Value == max)
                    return pair.Key;
            }

            return typeMap[0];
        }

        private static int GetMostCommonBirdCount(int[] types)
        {
            var grouped = types.GroupBy(i => i).
                Select(group => new {type = group.Key, Count = group.Count()}).
                OrderByDescending(arg => arg.Count).First();
            return grouped.type;
        }
    }
}
