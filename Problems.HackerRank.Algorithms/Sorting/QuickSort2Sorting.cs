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

            if (left.Count <= 1 && right.Count <= 1)
            {
                List<int> toPrint = new List<int>(3);
                if (left.Count == 1)
                {
                    accum.Add(left[0]);
                    toPrint.Add(left[0]);
                }

                accum.Add(pivot);
                toPrint.Add(pivot);

                if (right.Count == 1)
                {
                    accum.Add(right[0]);
                    toPrint.Add(right[0]);
                }

                PrintList(toPrint);

                return result;
            }

            if (left.Count > 0)
            {
                var leftPartition = Partition(left);
                PartitionSort3(leftPartition, accum);
            }
            accum.Add(pivot);

            if (right.Count > 0)
            {
                var rightPartition = Partition(right);
                PartitionSort3(rightPartition, accum);
            }

            PrintList(accum);

            return Tuple.Create(left, END_NUMBER, right);
        }

        private static void PrintList(IEnumerable<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
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
