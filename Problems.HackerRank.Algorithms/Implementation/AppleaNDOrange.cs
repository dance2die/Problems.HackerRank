using System;

/*
INPUT:
7 11
5 15
3 2
-2 2 1
5 -6
OUTPUT:
1
1
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Apple and Orange
    /// https://www.hackerrank.com/challenges/apple-and-orange
    /// </summary>
    public class AppleAndOrange
    {
        public static void Main(String[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, int.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, int.Parse);

            int appleCount = GetFruitCount(s, t, a, m, apple);
            int orangeCount = GetFruitCount(s, t, b, n, orange);

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }

        private static int GetFruitCount(int fromHouse, int toHouse, int treeAt, int fruitFallCount, int[] fruitsDroppedAt)
        {
            int fruitCount = 0;

            foreach (int fruitDroppedAt in fruitsDroppedAt)
            {
                int fallLocation = treeAt + fruitDroppedAt;
                if (fromHouse <= fallLocation && fallLocation <= toHouse)
                    fruitCount++;
            }

            return fruitCount;
        }
    }
}
