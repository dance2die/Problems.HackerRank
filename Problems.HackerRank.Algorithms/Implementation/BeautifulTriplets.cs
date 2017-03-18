using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
7 3
1 2 4 5 7 8 10
OUTPUT: 3
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Beautiful Triplets
    /// https://www.hackerrank.com/challenges/beautiful-triplets
    /// </summary>
    public class BeautifulTriplets
    {
        public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            // ignore array length, "n": the length of the sequence.
            int d = int.Parse(firstLine[1]);
            // Array of numbers on the second line.
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = GetBeautifulTripletCount(a, d);
            Console.WriteLine(count);
        }

        private static int GetBeautifulTripletCount(int[] a, int difference)
        {
            HashSet<int> set = new HashSet<int>(a);
            int count = 0;

            for (int i = 0; i < a.Length - 2; i++)
            {
                if (HasBeautifulTriplet(a, i, set, difference))
                    count++;
            }

            return count;
        }

        private static bool HasBeautifulTriplet(int[] a, int startIndex, HashSet<int> set, int difference)
        {
            const int limit = 3;
            int startNumber = a[startIndex];

            int count = 0;
            for (int j = startIndex; j < a.Length; j++)
            {
                if (set.Contains(startNumber))
                    count++;

                if (count == limit)
                    return true;

                startNumber += difference;
            }

            return false;
        }
    }
}
