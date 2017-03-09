using System;

/*
INPUT:
8 2
0 0 1 0 0 1 1 0
OUTPUT: 92
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Jumping on the Clouds: Revisited
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited
    /// </summary>
    public class JumpingOnTheCloudsRevisited
    {
        public static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens[0]);
            int k = Convert.ToInt32(tokens[1]);
            string[] temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(temp, int.Parse);

            int energy = GetEnergyAfterJumping(c, k);
            Console.WriteLine(energy);
        }

        private static int GetEnergyAfterJumping(int[] a, int k)
        {
            int energy = 100;
            int n = a.Length;

            Func<int, bool> isThunderCloud = val => val == 1;

            for (int i = 0; i < energy; i+=k, energy--)
            {
                if (isThunderCloud(a[i]))
                    energy -= 2;

                if (i > 0 && (i + k) % n == 0)
                    return --energy;
            }

            return energy;
        }
    }
}
