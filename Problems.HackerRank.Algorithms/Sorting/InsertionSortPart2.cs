using System;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Insertion Sort - Part 2
    /// https://www.hackerrank.com/challenges/insertionsort2
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class InsertionSortPart2 : BaseSorting
    {
        public static void Main(string[] args)
        {
            var arraySize = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[arraySize];
            String elements = Console.ReadLine();
            String[] elementsSplit = elements.Split(' ');
            for (int i = 0; i < arraySize; i++)
            {
                a[i] = Convert.ToInt32(elementsSplit[i]);
            }
/*
INPUT:
6
1 4 3 5 6 2
OUTPUT:
1 4 3 5 6 2 
1 3 4 5 6 2 
1 3 4 5 6 2 
1 3 4 5 6 2 
1 2 3 4 5 6 
 */

            InsertionSort(a);
        }

        private static void InsertionSort(int[] ar)
        {
            
        }
    }
}
