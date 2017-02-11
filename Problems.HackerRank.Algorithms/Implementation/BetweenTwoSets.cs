using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Between Two Sets
    /// https://www.hackerrank.com/challenges/between-two-sets
    /// </summary>
    public class BetweenTwoSets
    {
        public static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, int.Parse);
/*
INPUT:
2 3
2 4
16 32 96
OUTPUT: 3

INPUT:
10 10
100 99 98 97 96 95 94 93 92 91
1 2 3 4 5 6 7 8 9 10
OUTPUT: 0

INPUT:
1 3
2
20 30 12
OUTPUT: 1

INPUT:
3 2
3 9 6
36 72
OUTPUT: 2

INPUT:
1 1
1
100
OUTPUT: 9

INPUT:
1 2
1
72 48
OUTPUT: 8

*/

            var count = GetBetweenNumberCount(a, b);
            Console.WriteLine(count);
        }



        private static int GetBetweenNumberCount(int[] a, int[] b)
        {
            int aMax = a.Max();
            int bMin = b.Min();

            int count = CheckIfRestAreFactorsOfMax(a, aMax) && CheckIfMinIsFactorOfRest(b, aMax) ? 1 : 0;

            //foreach (int aValue in a)
            for (int i = 1; i <= bMin; i++)
            {
                var aMulti = i * aMax;
                if (aMulti == aMax && aMax >= 1) continue;

                if (CheckIfRestAreFactorsOfMax(a, aMulti) && CheckIfMinIsFactorOfRest(b, aMulti))
                    count++;
            }

            return count;
        }

        private static bool CheckIfMinIsFactorOfRest(int[] b, int bMin)
        {
            foreach (var bValue in b.Where(val => val != bMin))
            {
                if (bValue%bMin != 0)
                    return false;
            }
            return true;
        }

        private static bool CheckIfRestAreFactorsOfMax(int[] a, int aMax)
        {
            foreach (var aValue in a.Where(val => val != aMax))
            {
                if (aMax%aValue != 0)
                    return false;
            }
            return true;
        }
    }
}
