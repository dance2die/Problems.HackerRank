using System;

/*
INPUT:
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0
OUTPUT: 19
 */
namespace Problems.HackerRank.DataStructure.Arrays
{
    /// <summary>
    /// 2D Array - DS
    /// https://www.hackerrank.com/challenges/2d-array
    /// </summary>
    public class TwoDArrayDS
    {
        const int ARRAY_SIZE = 6;

        public static void Main(string[] args)
        {
            int[][] a = new int[ARRAY_SIZE][];
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                string[] tempArray = Console.ReadLine().Split(' ');
                a[i] = Array.ConvertAll(tempArray, int.Parse);
            }

            int maxSum = GetMaxSum(a);
            Console.WriteLine(maxSum);
        }

        private static int GetMaxSum(int[][] a)
        {
            int maxSum = 0;
            for (int i = 0; i < ARRAY_SIZE - 2; i++)
            {
                for (int j = 0; j < ARRAY_SIZE - 2; j++)
                {
                    int sum = GetSomeBetween(a, i, j);
                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            return maxSum;
        }

        private static int GetSomeBetween(int[][] a, int i, int j)
        {
            return a[i][j] + a[i][j + 1] + a[i][j + 2] + a[i + 1][j + 1] + a[i + 2][j] + a[i + 2][j + 1] + a[i + 2][j + 2];
        }
    }
}
