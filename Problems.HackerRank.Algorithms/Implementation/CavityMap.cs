using System;

/*
INPUT: sample case #1
4
1112
1912
1892
1234
OUTPUT:
1112
1X12
18X2
1234
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Cavity Map
    /// https://www.hackerrank.com/challenges/cavity-map
    /// </summary>
    public class CavityMap
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] matrix = GetMatrix(n);
        }

        private static string[,] GetMatrix(int n)
        {
            string[,] result = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    result[i, j] = line[j].ToString();
                }
            }

            return result;
        }
    }
}
