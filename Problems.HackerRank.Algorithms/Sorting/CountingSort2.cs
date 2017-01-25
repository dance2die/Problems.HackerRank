using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Counting Sort 2
    /// https://www.hackerrank.com/challenges/countingsort2
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class CountingSort2
    {
        public static void Main(string[] args)
        {
            Console.ReadLine(); // ignore array size.
            var strings = Console.ReadLine().Split(' ');
            //var strings = "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33".Split(' ');
            int[] values = Array.ConvertAll(strings, int.Parse);

/*
INPUT:
100
63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33
OUTPUT:
1 1 3 3 6 8 9 9 10 12 13 16 16 18 20 21 21 22 23 24 25 25 25 27 27 30 30 32 32 32 33 33 33 34 39 39 40 40 41 42 43 44 44 46 46 48 50 53 56 56 57 59 60 61 63 65 67 67 68 69 69 69 70 70 73 73 74 75 75 76 78 78 79 79 80 81 81 82 83 83 84 85 86 86 87 87 89 89 89 90 90 91 92 94 95 96 98 98 99 99
*/

            var table = GetCountTable(values);
            PrintTable(table);
        }

        private static void PrintTable(Dictionary<int, int> table)
        {
            foreach (KeyValuePair<int, int> pair in table)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    Console.Write("{0} ", pair.Key);
                }
            }
        }

        private const int OUTPUT_SIZE = 100;

        private static Dictionary<int, int> GetCountTable(int[] values)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>(OUTPUT_SIZE);
            for (int i = 0; i < OUTPUT_SIZE; i++)
            {
                lookup.Add(i, 0);
            }

            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];
                if (lookup.ContainsKey(value))
                    lookup[value]++;
                else
                    lookup.Add(value, 1);
            }

            return lookup.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}
