using System;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Running Time of Algorithms
    /// https://www.hackerrank.com/challenges/runningtime
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class RunningTimeOfAlgorithms
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            int[] a = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();

/*
INPUT:
5
2 1 3 1 2
 
OUTPUT:
4
*/

            var shiftCount = InsertionSort(a);
            Console.WriteLine(shiftCount);
        }

        public static int InsertionSort(int[] a)
        {
            var j = 0;
            int shiftCount = 0;
            for (var i = 0; i < a.Length; i++)
            {
                var value = a[i];
                j = i - 1;
                while (j >= 0 && value < a[j])
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                    shiftCount++;
                }
                a[j + 1] = value;
            }

            return shiftCount;
        }
    }
}
