using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Quicksort 2 - Sorting
    /// https://www.hackerrank.com/challenges/quicksort2
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class QuickSort2Sorting
    {
        private const int END_NUMBER = int.MinValue;

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

        //private static Tuple<List<int>, int, List<int>> PartitionSort(List<int> left, int pivot, List<int> right)
        private static void QuickSort(int[] a)
        {
            var accum = new List<int>();
            PartitionSort3(Partition(a), accum);
            Console.WriteLine(accum);
        }

        private static Tuple<List<int>, int, List<int>> PartitionSort3(
            Tuple<List<int>, int, List<int>> partition, List<int> accum)
        {
            var pivot = partition.Item2;
            var left = partition.Item1;
            var right = partition.Item3;

            var result = Tuple.Create(left, pivot, right);
            if (left.Count == 0 && right.Count == 0)
            {
                accum.Add(pivot);
                return result;
            }

            if (left.Count > 0)
            {
                var leftPartition = Partition(left);
                Tuple<List<int>, int, List<int>> leftSorted = PartitionSort3(leftPartition, accum);
            }
            accum.Add(pivot);

            if (right.Count > 0)
            {
                var rightPartition = Partition(right);
                Tuple<List<int>, int, List<int>> rightSorted = PartitionSort3(rightPartition, accum);
            }

            PrintPartition(result);

            return Tuple.Create(left, END_NUMBER, right);
        }

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

        private static void PrintPartition(Tuple<List<int>, int, List<int>> partition)
        {
            var pivot = partition.Item2;
            var left = partition.Item1;
            var right = partition.Item3;

            var leftValue = left.Count < 1 ? "" : left[0] + " ";
            var pivotValue = right.Count >= 1 ? pivot + " " : pivot.ToString();
            var rightValue = right.Count < 1 ? "" : right[0].ToString();
            Console.WriteLine("{0}{1}{2}", leftValue, pivotValue, rightValue);
        }

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
