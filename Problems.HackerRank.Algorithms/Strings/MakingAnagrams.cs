using System;

/*
INPUT:
cde
abc
OUTPUT: 4
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Making Anagrams
    /// https://www.hackerrank.com/challenges/making-anagrams
    /// </summary>
    public class MakingAnagrams
    {
        public static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();


            int differenceA = GetAnagramCount(a, b);
            int differenceB = GetAnagramCount(b, a);

            int count = differenceA + differenceB;
            Console.WriteLine(count);
        }

        private static int GetAnagramCount(string a, string b)
        {
            int total = 0;
            for (int i = 0; i < b.Length; i++)
            {
                var c = b[i];

                int index = a.IndexOf(c);
                if (index < 0)
                {
                    total++;
                }
                else
                {
                    a = a.Remove(index, 1);
                }

                b = b.Remove(i, 1);
                i--;
            }

            return total;
        }
    }
}
