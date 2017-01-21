using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Insertion Sort - Part 2
    /// https://www.hackerrank.com/challenges/insertionsort2
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class InsertionSortPart2
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

INPUT:
9
9 8 6 7 3 5 4 1 2
OUTPUT:
8 9 6 7 3 5 4 1 2
6 8 9 7 3 5 4 1 2
6 7 8 9 3 5 4 1 2
3 6 7 8 9 5 4 1 2
3 5 6 7 8 9 4 1 2
3 4 5 6 7 8 9 1 2
1 3 4 5 6 7 8 9 2
1 2 3 4 5 6 7 8 9
 
             */

            InsertionSort(a);
        }

        private static void InsertionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                SortFor(a, i + 1);
                PrintArray(a);
            }
        }

        /// <returns>True if element has been moved</returns>
        private static bool SortFor(int[] a, int currentIndex)
        {
            int value = a[currentIndex];

            bool isMoved = false;
            for (int i = currentIndex; i >= 1; i--)
            {
                if (a[i - 1] > value)
                {
                    var temp = a[i - 1];
                    a[i] = temp;
                    a[i - 1] = value;

                    isMoved = true;
                }
            }

            return isMoved;
        }

        private static void PrintArray(int[] a)
        {
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
