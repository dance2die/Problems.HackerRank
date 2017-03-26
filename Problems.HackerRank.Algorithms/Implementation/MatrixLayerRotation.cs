using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
INPUT:
4 4 1
1 2 3 4
5 6 7 8
9 10 11 12
13 14 15 16
OUTPUT:
2 3 4 8
1 7 11 12
5 6 10 16
9 13 14 15

INPUT:
4 4 2
1 2 3 4
5 6 7 8
9 10 11 12
13 14 15 16
OUTPUT:
3 4 8 12
2 11 10 16
1 7 6 15
5 9 13 14

INPUT:
5 4 7
1 2 3 4
7 8 9 10
13 14 15 16
19 20 21 22
25 26 27 28
OUTPUT:
28 27 26 25
22 9 15 19
16 8 21 13
10 14 20 7
4 3 2 1

INPUT:
2 2 3
1 1
1 1
OUTPUT:
1 1
1 1

 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Matrix Layer Rotation
    /// https://www.hackerrank.com/challenges/matrix-rotation-algo?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    /// </summary>
    public class MatrixLayerRotation
    {
        public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int m = int.Parse(firstLine[0]);
            int n = int.Parse(firstLine[1]);
            int r = int.Parse(firstLine[2]);

            int[,] matrix = GetMatrix(m, n);
        }

        private static int[,] GetMatrix(int m, int n)
        {
            int[,] result = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < numbers.Count; j++)
                {
                    result[i, j] = numbers[j];
                }
            }

            return result;
        }
    }
}
