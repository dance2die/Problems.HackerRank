using System;

/*
INPUT:
9 6 2015
6 6 2015
OUTPUT: 45
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Library Fine
    /// https://www.hackerrank.com/challenges/library-fine
    /// </summary>
    public class LibraryFine
    {
        public static void Main(string[] args)
        {
            string[] actualDateTokens = Console.ReadLine().Split(' ');
            int d1 = Convert.ToInt32(actualDateTokens[0]);
            int m1 = Convert.ToInt32(actualDateTokens[1]);
            int y1 = Convert.ToInt32(actualDateTokens[2]);
            string[] expectedDateTokens = Console.ReadLine().Split(' ');
            int d2 = Convert.ToInt32(expectedDateTokens[0]);
            int m2 = Convert.ToInt32(expectedDateTokens[1]);
            int y2 = Convert.ToInt32(expectedDateTokens[2]);

            DateTime actualDate = new DateTime(y1, m1, d1);
            DateTime expectedDate = new DateTime(y2, m2, d2);

            int fine = GetFine(actualDate, expectedDate);
            Console.WriteLine(fine);
        }

        private static int GetFine(DateTime actualDate, DateTime expectedDate)
        {
            // case 1: book was returned on and before expected date
            if (actualDate <= expectedDate) return 0;

            // book was reutrned after expected date. Need to pay fine.

            // case 2: the book is returned after the expected return day but still within the same calendar month and year as the expected return date
            if (actualDate.Month <= expectedDate.Month && actualDate.Year <= expectedDate.Year)
            {
                int totalDays = (int) (actualDate - expectedDate).TotalDays;
                return 15 * totalDays;
            }

            // case 3: the book is returned after the expected return month but still within the same calendar year as the expected return date
            if (actualDate.Year <= expectedDate.Year)
            {
                int totalMonths = actualDate.Month - expectedDate.Month;
                return 500 * totalMonths;
            }

            // case 4: the book is returned after the calendar year in which it was expected
            return 10000;
        }
    }
}
