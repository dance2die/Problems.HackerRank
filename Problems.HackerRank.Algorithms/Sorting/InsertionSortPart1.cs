using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Insertion Sort - Part 1
    /// https://www.hackerrank.com/challenges/insertionsort1
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class InsertionSortPart1 : BaseSorting
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

/*
            INPUT:
            5
            2 4 6 8 3
            OUTPUT:
            2 4 6 8 8 
            2 4 6 6 8 
            2 4 4 6 8 
            2 3 4 6 8 
            
            INPUT:
            14
            1 3 5 9 13 22 27 35 46 51 55 83 87 23
            OUTPUT:
            1 3 5 9 13 22 27 35 46 51 55 83 87 87
            1 3 5 9 13 22 27 35 46 51 55 83 83 87
            1 3 5 9 13 22 27 35 46 51 55 55 83 87
            1 3 5 9 13 22 27 35 46 51 51 55 83 87
            1 3 5 9 13 22 27 35 46 46 51 55 83 87
            1 3 5 9 13 22 27 35 35 46 51 55 83 87
            1 3 5 9 13 22 27 27 35 46 51 55 83 87
            1 3 5 9 13 22 23 27 35 46 51 55 83 87
            
            INPUT:
            10
            2 3 4 5 6 7 8 9 10 1
            OUTPUT:
            2 3 4 5 6 7 8 9 10 10
            2 3 4 5 6 7 8 9 9 10
            2 3 4 5 6 7 8 8 9 10
            2 3 4 5 6 7 7 8 9 10
            2 3 4 5 6 6 7 8 9 10
            2 3 4 5 5 6 7 8 9 10
            2 3 4 4 5 6 7 8 9 10
            2 3 3 4 5 6 7 8 9 10
            2 2 3 4 5 6 7 8 9 10
            1 2 3 4 5 6 7 8 9 10
             */

            InsertionSort(a);
        }

        private static void InsertionSort(int[] a)
        {
            int value = a.Last();

            bool done = false;
            for (int i = a.Length - 2; i >= 0; i--)
            {
                a[i + 1] = a[i];

                if (a[i] <= value)
                {
                    a[i + 1] = value;
                    done = true;
                }

                PrintArray(a);

                if (done) break;
            }

            if (a[0] > value)
            {
                a[0] = value;
                PrintArray(a);
            }
        }
    }
}