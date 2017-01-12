using System;

namespace Problems.HackerRank.Algorithms.WarmUp
{
    /// <summary>
    /// Answer for https://www.hackerrank.com/challenges/circular-array-rotation
    /// </summary>
    public class CircularArrayRotationMain
    {
        public static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int[] indexes = new int[q];
            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                indexes[a0] = m;
            }

            a = RotateRightNTimes2(a, k);

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine(a[indexes[i]]);
            }
        }

        private static int[] RotateRightNTimes2(int[] a, int rotateCount)
        {
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[(i + rotateCount) % a.Length] = a[i];
            }

            return result;
        }

        private static int[] RotateRightNTimes(int[] a, int k)
        {
            int[] result = a;
            for (int rotateIndex = 0; rotateIndex < k; rotateIndex++)
            {
                result = RotateRightOnce(result);
            }

            return result;
        }

        private static int[] RotateRightOnce(int[] a)
        {
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[(i + 1) % a.Length] = a[i];
            }

            return result;
        }
    }

}
