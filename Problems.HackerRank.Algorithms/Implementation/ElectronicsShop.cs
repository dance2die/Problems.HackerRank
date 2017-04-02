using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Electronics Shop
    /// https://www.hackerrank.com/challenges/electronics-shop
    /// </summary>
    public class ElectronicsShop
    {
        public static void Main()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
            string[] pendrives_temp = Console.ReadLine().Split(' ');
            int[] pendrives = Array.ConvertAll(pendrives_temp, Int32.Parse);
        }
    }
}
