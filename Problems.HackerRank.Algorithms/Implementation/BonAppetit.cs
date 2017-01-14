using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Bon Appétit
    /// https://www.hackerrank.com/challenges/bon-appetit
    /// </summary>
    public class BonAppetit
    {
        public static void Main(string[] args)
        {
            var nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            string costText = Console.ReadLine();
            int[] costs = Array.ConvertAll(costText.Split(' '), int.Parse);

            int charged = int.Parse(Console.ReadLine());

            int actual = 0;
            for (int i = 0; i < costs.Length; i++)
            {
                if (i != k)
                    actual += costs[i];
            }
            actual /= 2;

            var difference = charged - actual;
            Console.WriteLine(difference == 0 ? "Bon Appetit" : difference.ToString());
        }
    }
}
