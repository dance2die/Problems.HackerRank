/*
INPUT:
5 4
1 2 3 4 5
OUTPUT:
5 1 2 3 4
 */

using System;

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

            string output = GetLeftRotationText(a, rotationCount);
            Console.WriteLine(output);
        }

        private static string GetLeftRotationText(int[] a, int rotationCount)
        {
            return "";
        }
    }
}
