using System;
using System.Collections.Generic;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Find the Median
    /// https://www.hackerrank.com/challenges/find-the-median
    /// </summary>
    public class FindTheMedian
    {
        public static void Main()
        {
            Console.ReadLine(); // ignore array size.
            var values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

/*
INPUT:
7
0 1 2 4 6 5 3
OUTPUT: 3
*/
            // Partition Until left & right size is NOT the SAME.
            int pivotIndex = 0;
            var partition = Partition(values, pivotIndex++);
            while (partition.Item1.Count != partition.Item3.Count)
            {
                partition = Partition(values, pivotIndex++);
            }

            Console.WriteLine(partition.Item2);
        }

        private static int[] ConvertPartitionToArray(Tuple<List<int>, int, List<int>> partition)
        {
            const int pivotSize = 1;
            var newSize = partition.Item1.Count + pivotSize + partition.Item3.Count;

            List<int> result = new List<int>(newSize);
            result.AddRange(partition.Item1);
            result.Add(partition.Item2);
            result.AddRange(partition.Item3);

            return result.ToArray();
        }

        private static Tuple<List<int>, int, List<int>> Partition(int[] a, int pivotIndex)
        {
            int partitionSize = a.Length / 2;
            var left = new List<int>(partitionSize);
            var pivot = a[pivotIndex];
            var right = new List<int>(partitionSize);

            for (int i = 0; i < a.Length; i++)
            {
                if (i == pivotIndex) continue;

                int value = a[i];

                if (value < pivot)
                    left.Add(value);

                if (value > pivot)
                    right.Add(value);
            }

            return Tuple.Create(left, pivot, right);
        }
    }
}
