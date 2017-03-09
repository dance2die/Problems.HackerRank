using System;
using System.Collections.Generic;

/*
INPUT:
3
2 3 1
OUTPUT:
2
3
1
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Sequence Equation
    /// https://www.hackerrank.com/challenges/permutation-equation
    /// </summary>
    public class SequenceEquation
    {
        public static void Main()
        {
            Console.ReadLine(); // Ignore elemnt count
            var split = Console.ReadLine().Split(' ');
            var sequences = Array.ConvertAll(split, int.Parse);

            PrintSequences(sequences);
        }

        private static void PrintSequences(int[] sequences)
        {
            Dictionary<int, int> map = GetMap(sequences);

            for (int i = 1; i <= sequences.Length; i++)
            {
                var key1 = map[i];
                var key2 = map[key1];
                Console.WriteLine(key2);
            }
        }

        private static Dictionary<int, int> GetMap(int[] sequences)
        {
            var result = new Dictionary<int, int>(sequences.Length);
            for (int i = 1; i <= sequences.Length; i++)
            {
                result.Add(sequences[i - 1], i);
            }
            return result;
        }
    }
}
