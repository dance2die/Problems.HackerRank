using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT: sample case
5 3
4 2 6 1 10
OUTPUT: 4

INPUT: case #3
25 10
1 29 94 15 87 100 20 55 100 45 82 80 100 100 3 53 100 2 100 100 100 100 100 100 1
OUTPUT: 11

INPUT: case #5
40 7
1 10 12 4 11 6 8 15 23 24 23 24 39 34 50 3 58 62 71 79 95 100 2 2 100 100 100 100 100 100 1 100 100 100 100 100 3 100 100 100
OUTPUT: 12

INPUT: case #6
1 1
100
OUTPUT: 100
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

            int chapter = 0;
            foreach (int problemCount in problemCounts)
            {
                chapter++;

                for (int i = 1; i <= problemCount; i++)
                {
                    if (i != 1 && i % maxProblemsPerPage == 1)
                        page++;

                    if (page == i)
                        specialPageCount++;

                    if (maxProblemsPerPage == 1)
                        page++;
                }

                page++;
            }

            return specialPageCount;
        }
    }
}
