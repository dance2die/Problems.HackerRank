/*
INPUT:
5 4
1 2 3 4 5
OUTPUT:
5 1 2 3 4

INPUT:
5 3
1 2 3 4 5
OUTPUT:
4 5 1 2 3
 */

using System;
using System.Linq;

namespace Problems.HackerRank.DataStructure.Arrays
{
    /// <summary>
    /// Left Rotation
    /// https://www.hackerrank.com/challenges/array-left-rotation
    /// </summary>
    public class LeftRotation
    {
        public static void Main()
        {
            var firstLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int size = firstLine[0];
            int rotationCount = firstLine[1];
            var a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] output = GetLeftRotationText(a, rotationCount);
            PrintOutput(output);
        }

        private static int[] GetLeftRotationText(int[] a, int rotationCount)
        {
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[(a.Length + i - rotationCount) % a.Length] = a[i];
            }

            return result;
        }

        private static void PrintOutput(int[] output)
        {
            Console.WriteLine(string.Join(" ", output.ToArray()));
        }
    }
}
