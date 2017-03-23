using System;
using System.Linq;

/*
INPUT: sample case #1
5
2 3 4 5 6
OUTPUT: 4

INPUT: sample case #2
2
1 2
OUTPUT: NO
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Fair Rations
    /// https://www.hackerrank.com/challenges/fair-rations
    /// </summary>
    public class FairRations
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] B_temp = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(B_temp, Int32.Parse);

            PrintSteps(B);
        }

        private static void PrintSteps(int[] a)
        {
            if (CannotBeDone(a))
            {
                Console.WriteLine("NO");
            }
            else
            {
                int steps = GetSteps(a);
                Console.WriteLine(steps);
            }
        }

        private static int GetSteps(int[] a)
        {
            int steps = 0;

            while (!IsEveryElementEven(a))
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (IsOdd(a[i]))
                    {
                        a[i]++;
                        a[i + 1]++;

                        steps += 2;
                        break;
                    }
                }
            }

            return steps;
        }

        private static bool IsEveryElementEven(int[] a)
        {
            foreach (int i in a)
            {
                if (IsOdd(i)) return false;
            }
            return true;
        }

        private static bool IsOdd(int val)
        {
            return val % 2 == 1;
        }

        /// <summary>
        /// If a sum is odd, then it cannot be done.
        /// </summary>
        private static bool CannotBeDone(int[] a)
        {
            return a.Sum() % 2 == 1;
        }
    }
}
