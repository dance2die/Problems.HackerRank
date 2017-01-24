using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    public class QuickSort2Sorting
    {
        /// <summary>
        /// Quicksort 2 - Sorting
        /// https://www.hackerrank.com/challenges/quicksort2
        /// from https://www.hackerrank.com/challenges/tutorial-intro
        /// </summary>
        public static void Main(string[] args)
        {
            var arraySize = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[arraySize];
            string elements = Console.ReadLine();
            string[] elementsSplit = elements.Split(' ');
            for (int i = 0; i < arraySize; i++)
            {
                a[i] = Convert.ToInt32(elementsSplit[i]);
            }
/*
INPUT:
7
5 8 1 3 7 9 2 

OUTPUT:
2 3
1 2 3
7 8 9
1 2 3 5 7 8 9
*/

            QuickSort(a);
        }

        private static void QuickSort(int[] a)
        {
            PartitionSort(Partition(a));
        }

        private List<int> _values = new List<int>();

        //private static Tuple<List<int>, int, List<int>> PartitionSort(List<int> left, int pivot, List<int> right)
        private static Tuple<List<int>, int, List<int>> PartitionSort(Tuple<List<int>, int, List<int>> partition)
        {
            if (partition.Item1.Count <= 1 && partition.Item3.Count <= 1)
                return partition;

            var pivot = partition.Item2;
            var left = partition.Item1;
            var right = partition.Item3;

            var a = ConvertToArray(pivot, left, right).ToArray();

            var partitioned = Partition(a);
            var l = partitioned.Item1;
            var p = partitioned.Item2;
            var r = partitioned.Item3;

            var leftPartition = Partition(l);
            var leftPartitionResult = PartitionSort(leftPartition);

            var rightPartition = Partition(r);
            var rightPartitionResult = PartitionSort(rightPartition);

            Console.WriteLine("{0}{1}{2}", leftPartitionResult.Item2, p, rightPartitionResult.Item2);

            var emptyList = new List<int>(0);
            return Tuple.Create(emptyList, 0, emptyList);
        }

        private static List<int> ConvertToArray(int pivot, List<int> left, List<int> right)
        {
            var list = new List<int> {pivot};
            list.AddRange(left);
            list.AddRange(right);
            return list;
        }

        private static Tuple<List<int>, int, List<int>> Partition(IList<int> a)
        {
            if (a.Count < 1)
            {
                var emptyList = new List<int>(0);
                return Tuple.Create(emptyList, 0, emptyList);
            }

            var pivot = a[0];
            int partitionSize = a.Count / 2;
            var left = new List<int>(partitionSize);
            var right = new List<int>(partitionSize);

            for (int i = 1; i < a.Count; i++)
            {
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
