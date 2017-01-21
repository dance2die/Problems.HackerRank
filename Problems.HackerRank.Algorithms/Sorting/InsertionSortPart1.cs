using System;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Insertion Sort - Part 1
    /// https://www.hackerrank.com/challenges/insertionsort1
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class InsertionSortPart1
    {
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

            InsertionSort(a);
        }

        private static void InsertionSort(int[] a)
        {
            
        }
    }
}
