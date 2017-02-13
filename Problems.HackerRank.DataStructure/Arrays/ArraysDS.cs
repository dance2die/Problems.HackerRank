using System;

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
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);


        }
    }
}
