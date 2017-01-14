using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Equalize the Array
    /// https://www.hackerrank.com/challenges/equality-in-a-array
    /// </summary>
    public class EqualizeTheArray
    {
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] tempStrings = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(tempStrings, int.Parse);
            int[] a = tempStrings.Select(int.Parse).ToArray();
/* 
input:
5
3 3 2 1 3
output:
2

input:
88
69 86 100 69 55 83 15 69 86 69 79 16 86 24 24 55 16 69 100 79 16 83 83 79 15 15 86 16 55 18 100 100 86 16 83 79 86 83 100 83 55 15 86 86 55 100 55 18 55 100 86 69 83 24 16 55 100 16 100 24 16 55 15 79 16 18 16 16 83 83 69 18 100 79 16 24 79 16 69 86 83 79 83 18 15 100 24 83
output:
75
*/
            Stopwatch watch = new Stopwatch();
            watch.Start();

            var result1 = GetMinElementsToDelete(a);
            watch.Stop();
            Console.WriteLine("GetMinElementsToDelete took {0}", watch.Elapsed);

            watch.Start();
            var result2 = GetMinElementsToDelete2(a);
            watch.Stop();
            Console.WriteLine("GetMinElementsToDelete took {0}", watch.Elapsed);

            Console.WriteLine(result2);
        }

        private static int GetMinElementsToDelete2(int[] a)
        {
            // int1 => a[i], int2 => count
            var dictionary = new Dictionary<int, int>(a.Length);
            foreach (var key in a)
            {
                if (dictionary.ContainsKey(key))
                    dictionary[key]++;
                else
                    dictionary.Add(key, 1);
            }

            var maxCount = 0;
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (dictionary[a[i]] > maxCount)
                    maxCount = dictionary[a[i]];
            }

            return a.Length - maxCount;
        }

        private static int GetMinElementsToDelete(int[] a)
        {
            var groupings = a.GroupBy(value => value);
            var maxCount = groupings.Max(group => group.Count());

            var result = a.Length - maxCount;
            return result;
        }
    }
}
