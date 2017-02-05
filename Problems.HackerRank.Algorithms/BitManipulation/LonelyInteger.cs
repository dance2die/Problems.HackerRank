using System;

namespace Problems.HackerRank.Algorithms.BitManipulation
{
    /// <summary>
    /// Lonely Integer
    /// https://www.hackerrank.com/challenges/lonely-integer
    /// </summary>
    public class LonelyInteger
    {
        static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[arraySize];
            string move = Console.ReadLine();
            string[] split = move.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                var item = Convert.ToInt32(split[i]);
                a[i] = item;
            }
/*
INPUT:
5
0 0 1 2 1
OUTPUT: 2

INPUT:
1
1
OUTPUT: 1

INPUT:
3
1 1 2
OUTPUT: 2
*/
            var lonelyInteger = GetLonelyInteger(a);
            Console.WriteLine(lonelyInteger);
        }

        public static int GetLonelyInteger(int[] a)
        {
            int seed = 0;
            Func<int, string> toBin = value => Convert.ToString(value, 2);
            foreach (var i in a)
            {
                //Console.WriteLine("{0}({1}) ^ {2}({3}) = {4}:({5})", seed, toBin(seed), i, toBin(i), seed ^ i, toBin(seed ^ i));
                seed ^= i;
            }
            return seed;
        }
    }
}
