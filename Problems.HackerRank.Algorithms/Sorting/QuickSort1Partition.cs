using System;
using System.Collections.Generic;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Quicksort 1 - Partition
    /// https://www.hackerrank.com/challenges/quicksort1
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class QuickSort1Partition
    {
        public static void Main(string[] args)
        {
            var arraySize = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[arraySize];
            string elements = Console.ReadLine();
            if (elements != null)
            {
                string[] elementsSplit = elements.Split(' ');
                for (int i = 0; i < arraySize; i++)
                {
                    a[i] = Convert.ToInt32(elementsSplit[i]);
                }
            }
/*
INPUT:
5
4 5 3 7 2 

OUTPUT:
3 2 4 5 7
*/

            Partition(a);
        }

        private static void Partition(int[] a)
        {
            var p = a[0];
            int partitionSize = a.Length / 2;
            var left = new List<int>(partitionSize);
            var right = new List<int>(partitionSize);

            for (int i = 1; i < a.Length; i++)
            {
                int value = a[i];

                if (value < p)
                    left.Add(value);

                if (value > p)
                    right.Add(value);
            }

            Console.WriteLine("{0} {1} {2}", string.Join(" ", left.ToArray()), p, string.Join(" ", right.ToArray()));
        }
    }
}
