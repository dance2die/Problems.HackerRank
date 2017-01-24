using System;

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

            QuickSort(a);
        }

        private static void QuickSort(int[] a)
        {
            
        }
    }
}
