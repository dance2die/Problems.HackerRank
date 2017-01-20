using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Minimum Distances
    /// https://www.hackerrank.com/challenges/minimum-distances
    /// </summary>
    public class MinimumDistances
    {
        private const int NOT_FOUND = -1;

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] A_temp = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);
            /**
Input:
6
7 1 3 4 1 7
output: 3
             */

            int minimumDistance = GetMinimumDistance(A);

            Console.WriteLine(minimumDistance);
        }

        private static int GetMinimumDistance(int[] values)
        {
            int minimumDistance = int.MaxValue;

            for (int i = 0; i < values.Length; i++)
            {
                int nextIndex = GetNextIndex(i, values);
                if (nextIndex == NOT_FOUND) continue;

                int currentDistance = nextIndex - i;

                if (currentDistance < minimumDistance)
                    minimumDistance = currentDistance;
            }

            if (minimumDistance == int.MaxValue)
                return NOT_FOUND;

            return minimumDistance;
        }

        private static int GetNextIndex(int currentIndex, int[] values)
        {
            var currentValue = values[currentIndex];
            for (int i = currentIndex + 1; i < values.Length; i++)
            {
                int nextValue = values[i];
                if (currentValue == nextValue)
                    return i;
            }

            return NOT_FOUND;
        }
    }
}
