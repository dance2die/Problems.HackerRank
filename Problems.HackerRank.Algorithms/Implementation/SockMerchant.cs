using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Sock Merchant
    /// https://www.hackerrank.com/challenges/sock-merchant
    /// </summary>
    public class SockMerchant
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] socks = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(socks, int.Parse);

            /*
9
10 20 20 10 10 30 50 10 20
             */
            // output = 3 <-- 10/10 20/20 10/10

            var group = c.GroupBy(value => value);

            const int pair = 2;
            int pairCount = 0;
            foreach (IGrouping<int, int> grouping in group)
            {
                pairCount += grouping.Count() / pair;
            }

            Console.WriteLine(pairCount);
        }
    }
}
