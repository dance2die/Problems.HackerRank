using System;

/*
INPUT:
10 2 3
3 1
5 2 8
OUTPUT: 9

INPUT:
5 1 1
4
5
OUTPUT: -1
 */
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

            int moneySpent = GetMoneySpent(s, keyboards, pendrives);
            Console.WriteLine(moneySpent);
        }

        private static int GetMoneySpent(int money, int[] keyboards, int[] pendrives)
        {
            int max = -1;
            foreach (int keyboardPrice in keyboards)
            {
                foreach (int pendrivePrice in pendrives)
                {
                    int sum = keyboardPrice + pendrivePrice;
                    if (max < sum && sum < money)
                        max = sum;
                }
            }
            return max;
        }
    }
}
