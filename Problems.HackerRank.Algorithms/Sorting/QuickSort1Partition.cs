using System;

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

            Partition(a);
        }

        private static void Partition(int[] a)
        {
            
        }
    }
}
