using System;
using System.Collections.Generic;

/*
INPUT:
4
1 4 3 2
OUTPUT: 2 3 4 1
 */
namespace Problems.HackerRank.DataStructure.Arrays
{
    /// <summary>
    /// Arrays - DS
    /// https://www.hackerrank.com/challenges/arrays-ds
    /// </summary>
    public class ArraysDS
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(arr_temp, Int32.Parse);

            PrintArrayInReverseOrder(a);
        }

        private static void PrintArrayInReverseOrder(int[] a)
        {
            Stack<int> stack = new Stack<int>(a.Length);
            foreach (int value in a)
            {
                stack.Push(value);
            }

            string result = string.Join(" ", stack.ToArray());
            Console.WriteLine(result);
        }
    }
}
