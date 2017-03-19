using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
5 3  
4 2 6 1 10
OUTPUT: 4
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Lisa's Workbook
    /// https://www.hackerrank.com/challenges/lisa-workbook
    /// </summary>
    public class LisasWorkbook
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int chapterCount = int.Parse(firstLine[0]);
            int maxProblemsPerPage = int.Parse(firstLine[1]);
            List<int> problemCounts = Console.ReadLine().Split(' ').Select(val => int.Parse(val)).ToList();

            int specialPageCount = GetSpecialPageCount(problemCounts, maxProblemsPerPage);
            Console.WriteLine(specialPageCount);
        }

        private static int GetSpecialPageCount(List<int> problemCounts, int maxProblemsPerPage)
        {
            int specialPageCount = 0;
            int page = 1;

            foreach (int problemCount in problemCounts)
            {
                for (int i = 1; i <= problemCount; i++)
                {
                    if (page == i)
                        specialPageCount++;
                }
                page++;
            }

            return specialPageCount;
        }
    }
}
