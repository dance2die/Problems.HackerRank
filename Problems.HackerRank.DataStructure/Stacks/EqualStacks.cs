﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

/*
INPUT:
5 3 4
3 2 1 1 1
4 3 2
1 1 4 1
OUTPUT: 5

INPUT:
5 2 3
1 1 1 1 1
3 2
1 3 1
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
            //var lines = File.ReadAllLines(@".\Stacks\EqualStacks_TestCase30.txt");
            //string[] tokens_n1 = lines[0].Split(' ');
            //int n1 = Convert.ToInt32(tokens_n1[0]);
            //int n2 = Convert.ToInt32(tokens_n1[1]);
            //int n3 = Convert.ToInt32(tokens_n1[2]);
            //string[] h1_temp = lines[1].Split(' ');
            //int[] h1 = Array.ConvertAll(h1_temp, int.Parse);
            //string[] h2_temp = lines[2].Split(' ');
            //int[] h2 = Array.ConvertAll(h2_temp, int.Parse);
            //string[] h3_temp = lines[3].Split(' ');
            //int[] h3 = Array.ConvertAll(h3_temp, int.Parse);

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

            Stopwatch watch = new Stopwatch();
            watch.Start();

            long commonMaximumHeight = GetCommonMaximumHeight(h1, h2, h3);
            Console.WriteLine(commonMaximumHeight);

            watch.Stop();
            //Console.WriteLine("ellapsed: {0}", watch.Elapsed);
        }

        private static long GetCommonMaximumHeight(int[] h1, int[] h2, int[] h3)
        {
            var h1Accumulated = Accumulate(h1);
            var h2Accumulated = Accumulate(h2);
            var h3Accumulated = Accumulate(h3);

            var sorted = h1Accumulated.ToArray().Reverse();
            foreach (long value in sorted)
            {
                if (h2Accumulated.Contains(value) && h3Accumulated.Contains(value))
                    return value;
            }

            return 0;
        }

        private static HashSet<long> Accumulate(int[] a)
        {
            HashSet<long> result = new HashSet<long>();
            // accumulate from the beginning in reverse order.
            long prevValue = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            //for (int i = 0; i < a.Length; i++)
            {
                long accumulation = a[i] + prevValue;
                result.Add(accumulation);

                prevValue = accumulation;
            }

            return result;
        }
    }
}
