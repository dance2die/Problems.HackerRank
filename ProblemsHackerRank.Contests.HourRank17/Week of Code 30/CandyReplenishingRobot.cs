using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsHackerRank.Contests.Week_of_Code_30
{
    /// <summary>
    /// Candy Replenishing Robot
    /// https://www.hackerrank.com/contests/w30/challenges/candy-replenishing-robot
    /// </summary>
    public class CandyReplenishingRobot
    {
        public static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        }
    }
}
