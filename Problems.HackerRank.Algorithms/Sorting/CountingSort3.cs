using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Counting Sort 3
    /// https://www.hackerrank.com/challenges/countingsort3
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class CountingSort3
    {
        public static void Main(string[] args)
        {
            var lineCount = int.Parse(Console.ReadLine());

            List<int> values = new List<int>(lineCount);
            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine();
                values.Add(int.Parse(line.Split(' ')[0]));
            }


            var countTable = GetCountTable(values);
            PrintCountTable(countTable);

/*
INPUT:
10
4 that
3 be
0 to
1 be
5 question
1 or
2 not
4 is
2 to
4 the
 
OUTPUT:
1 3 5 6 9 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 
*/   
        }

        private static void PrintCountTable(Dictionary<int, int> countTable)
        {
            int accum = 0;
            for (int i = 0; i < countTable.Count; i++)
            {
                accum += countTable[i];
                Console.Write("{0} ", accum);
            }
        }

        private const int OUTPUT_SIZE = 100;

        private static Dictionary<int, int> GetCountTable(IEnumerable<int> values)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>(OUTPUT_SIZE);
            for (int i = 0; i < OUTPUT_SIZE; i++)
            {
                lookup.Add(i, 0);
            }

            var valueList = values as IList<int> ?? values.ToList();
            for (int i = 0; i < valueList.Count; i++)
            {
                int value = valueList[i];
                if (lookup.ContainsKey(value))
                    lookup[value]++;
                else
                    lookup.Add(value, 1);
            }

            return lookup.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
        }

    }
}
