using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
2
hello
world
hi
world
OUTPUT:
YES
NO
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    public class TwoStrings
    {
        public static void Main(string[] args)
        {
            int pairCount = int.Parse(Console.ReadLine());

            var areIntersecting = AreIntersecting(pairCount).ToList();
            areIntersecting.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> AreIntersecting(int pairCount)
        {
            for (int i = 0; i < pairCount; i++)
            {
                yield return IsIntersecting(Console.ReadLine(), Console.ReadLine());
            }
        }

        private static string IsIntersecting(string a, string b)
        {
            HashSet<char> setA = new HashSet<char>(a);
            HashSet<char> setB = new HashSet<char>(b);

            setA.IntersectWith(setB);

            return setA.Count > 0 ? "YES" : "NO";
        }
    }
}
