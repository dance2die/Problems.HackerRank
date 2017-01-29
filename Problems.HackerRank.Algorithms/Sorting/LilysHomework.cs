using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Lily's Homework
    /// https://www.hackerrank.com/challenges/lilys-homework
    /// </summary>
    public class LilysHomework
    {
        public static void Main(string[] args)
        {
            Console.ReadLine(); // ignore array size.
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
/*
INPUT:
4
2 5 3 1
OUTPUT:
2
 */
            int swapCount = GetMinimumSwapCountToSort(a);
            Console.WriteLine(swapCount);
        }

        private static int GetMinimumSwapCountToSort(int[] a)
        {
            var sorted = ((int[]) a.Clone()).ToList();
            sorted.Sort();

            int swapCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int currentLowest = sorted[i];
                int currentValue = a[i];
                if (currentValue > currentLowest)
                {
                    int currentLowestValueIndex = Array.IndexOf(a, currentLowest);
                    Swap(a, i, currentLowestValueIndex);
                    swapCount++;
                }
            }

            return swapCount;
        }

        private static void Swap(int[] a, int i1, int i2)
        {
            var temp = a[i1];
            a[i1] = a[i2];
            a[i2] = temp;
        }
    }
}
