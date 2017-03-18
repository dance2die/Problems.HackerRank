using System;

/*
INPUT:
6
2
OUTPUT: 1

INPUT:
5
4
OUTPUT: 0

INPUT:
11
6
OUTPUT: 3
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Drawing Book
    /// https://www.hackerrank.com/challenges/drawing-book
    /// </summary>
    public class DrawingBook
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());

            int pageCount = GetPageCount(n, p);
            Console.WriteLine(pageCount);
        }

        private static int GetPageCount(int totalPages, int page)
        {
            // Edge case
            if (totalPages == page) return 0;

            decimal at1 = page / 2;
            int from = (int) Math.Floor(at1);
            
            decimal at2 = (totalPages - page) / 2;
            int to = (int) Math.Floor(at2);

            return Math.Min(from, to);
        }
    }
}
