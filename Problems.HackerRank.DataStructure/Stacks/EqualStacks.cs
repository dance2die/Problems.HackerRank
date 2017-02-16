using System;

/*
INPUT:
5 3 4
3 2 1 1 1
4 3 2
1 1 4 1
OUTPUT: 5
 */
namespace Problems.HackerRank.DataStructure.Stacks
{
    /// <summary>
    /// Equal Stacks
    /// https://www.hackerrank.com/challenges/equal-stacks
    /// </summary>
    public class EqualStacks
    {
        public static void Main()
        {
            string[] tokens_n1 = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(tokens_n1[0]);
            int n2 = Convert.ToInt32(tokens_n1[1]);
            int n3 = Convert.ToInt32(tokens_n1[2]);
            string[] h1_temp = Console.ReadLine().Split(' ');
            int[] h1 = Array.ConvertAll(h1_temp, int.Parse);
            string[] h2_temp = Console.ReadLine().Split(' ');
            int[] h2 = Array.ConvertAll(h2_temp, int.Parse);
            string[] h3_temp = Console.ReadLine().Split(' ');
            int[] h3 = Array.ConvertAll(h3_temp, int.Parse);
        }
    }
}
