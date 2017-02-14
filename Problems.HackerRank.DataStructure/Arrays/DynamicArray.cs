/*
INPUT: 
2 5
1 0 5
1 1 7
1 0 3
2 1 0
2 1 1
OUTPUT:
7
3

 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.DataStructure.Arrays
{
    /// <summary>
    /// Dynamic Array
    /// https://www.hackerrank.com/challenges/dynamic-array
    /// </summary>
    public class DynamicArray
    {
        public static void Main(string[] args)
        {
            var firstLineInputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int sequenceCount = firstLineInputs[0];
            int queryCount = firstLineInputs[1];

            List<Query> queries = GetQueries(queryCount).ToList();
            Console.WriteLine(queries);
        }

        private static IEnumerable<Query> GetQueries(int queryCount)
        {
            for (int i = 0; i < queryCount; i++)
            {
                var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                yield return new Query(line[0], new List<int>(line.Skip(1).ToArray()));
            }
        }
    }

    public class Query
    {
        public int QueryType { get; set; }
        public List<int> Sequences { get; set; }

        public Query(int queryType, List<int> sequences)
        {
            QueryType = queryType;
            Sequences = sequences;
        }
    }
}
