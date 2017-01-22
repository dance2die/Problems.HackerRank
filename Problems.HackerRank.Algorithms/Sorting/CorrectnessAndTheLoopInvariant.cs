using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Correctness and the Loop Invariant
    /// https://www.hackerrank.com/challenges/correctness-invariant
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class CorrectnessAndTheLoopInvariant
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            int[] a = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
/*

INPUT:
6
1 4 3 5 6 2
OUTPUT:
1 2 3 4 5 6 

INPUT:
9
9 8 6 7 3 5 4 1 2
OUTPUT:
1 2 3 4 5 6 7 8 9

*/

            InsertionSort(a);
        }

        public static void InsertionSort(int[] a)
        {
            var j = 0;
            for (var i = 0; i < a.Length; i++)
            {
                var value = a[i];
                j = i - 1;
                while (j >= 0 && value < a[j])
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = value;
            }

            Console.WriteLine(string.Join(" ", a));
        }
    }
}
