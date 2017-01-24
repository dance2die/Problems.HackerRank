using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    public class QuickSort2Sorting
    {
        private static Tuple<List<int>, int, List<int>> PartitionSort2(Tuple<List<int>, int, List<int>> partition)
        {
            var pivot = partition.Item2;
            if (pivot == END_NUMBER)
                return partition;

            if (partition.Item1.Count <= 1 && partition.Item3.Count <= 1)
                return partition;

            var left = partition.Item1;
            var right = partition.Item3;

            var leftPartition = Partition(left);
            var leftResult = PartitionSort2(leftPartition);

            var rightPartition = Partition(left);
            var rightResult = PartitionSort2(rightPartition);

            Func<List<int>, string> toString = list => string.Join(" ", list.Select(c => c.ToString()).ToArray());
            Console.WriteLine("{0}{1}{2}", toString(leftResult.Item1), leftResult.Item2, toString(leftResult.Item3));
            Console.WriteLine("{0}{1}{2}", toString(rightResult.Item1), rightResult.Item2, toString(rightResult.Item3));

            return Tuple.Create(new List<int>(0), END_NUMBER, new List<int>(0));
        }

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
            PartitionSort3(Partition(a));
        }

        private static int PartitionSort3(Tuple<List<int>, int, List<int>> partition)
        {
            var pivot = partition.Item2;
            var left = partition.Item1;
            var right = partition.Item3;

            if (left.Count == 1) return left[0];
            if (right.Count == 1) return right[0];

            if (pivot == END_NUMBER)
                return pivot;


            int leftResult = PartitionSort3(Partition(left));
            int rightResult = PartitionSort3(Partition(right));

            Console.WriteLine("{0}{1}{2}", leftResult, pivot, rightResult);

            return END_NUMBER;
        }

        private const int END_NUMBER = int.MinValue;

        //private static Tuple<List<int>, int, List<int>> PartitionSort(List<int> left, int pivot, List<int> right)
        private static void PartitionSort(Tuple<List<int>, int, List<int>> partition)
        {
            if (partition.Item2 == END_NUMBER)
                return;

            var pivot = partition.Item2;
            var left = partition.Item1;
            var right = partition.Item3;

            var a = ConvertToArray(partition).ToArray();

            var partitioned = Partition(a);
            var l = partitioned.Item1;
            var p = partitioned.Item2;
            var r = partitioned.Item3;

            var leftPartition = Partition(l);
            PartitionSort(leftPartition);

            var rightPartition = Partition(r);
            PartitionSort(rightPartition);
        }

        private static List<int> ConvertToArray(Tuple<List<int>, int, List<int>> partition)
        {
            var pivot = partition.Item2;
            var left = partition.Item1;
            var right = partition.Item3;

            var list = new List<int> { pivot };
            list.AddRange(left);
            list.AddRange(right);

            return list;
        }

        private static Tuple<List<int>, int, List<int>> Partition(IList<int> a)
        {
            if (a.Count < 1)
            {
                var emptyList = new List<int>(0);
                return Tuple.Create(emptyList, END_NUMBER, emptyList);
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
