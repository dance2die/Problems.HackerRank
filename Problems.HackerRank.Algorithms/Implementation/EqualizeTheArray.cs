using System;
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
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
/* 
input:
5
3 3 2 1 3
output:
2
*/

            var groupings = a.GroupBy(value => value);
            var maxCount = groupings.Max(group => group.Count());

            var result = a.Length - maxCount;

            Console.WriteLine(result);
        }
    }
}
