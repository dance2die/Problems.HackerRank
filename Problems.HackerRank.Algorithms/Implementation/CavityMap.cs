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
            string[] grid = new string[n];
            for (int grid_i = 0; grid_i < n; grid_i++)
            {
                grid[grid_i] = Console.ReadLine();
            }
        }
    }
}
