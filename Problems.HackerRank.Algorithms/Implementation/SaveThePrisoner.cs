using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
1 
5 2 1
OUTPUT: 2

INPUT:
2
6 8 5
5 2 1
OUTPUT:
6
2

INPUT:
3
352926151 380324688 94730870
94431605 679262176 5284458
208526924 756265725 150817879
OUTPUT:
122129406
23525398
72975907
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Save the Prisoner!
    /// https://www.hackerrank.com/challenges/save-the-prisoner
    /// </summary>
    public class SaveThePrisoner
    {
        public static void Main(string[] args)
        {
            int testCaseCount = int.Parse(Console.ReadLine());
            List<PrisonerTestCase> testCases = GetPrisonerTestCases(testCaseCount).ToList();

            PrintWarnIds(testCases);
        }

        private static void PrintWarnId(PrisonerTestCase testCase)
        {
            int result = (testCase.PrisonerId + testCase.SweetCount - 1) % testCase.PrisonerCount;
            if (result == 0)
                result = testCase.PrisonerCount;
            Console.WriteLine(result);
        }

        private static void PrintWarnIds(List<PrisonerTestCase> testCases)
        {
            foreach (PrisonerTestCase testCase in testCases)
            {
                PrintWarnId(testCase);
            }
        }

        private static IEnumerable<PrisonerTestCase> GetPrisonerTestCases(int testCaseCount)
        {
            for (int i = 0; i < testCaseCount; i++)
            {
                var line = Console.ReadLine();
                var splitLine = line.Split(' ');
                var numbers = Array.ConvertAll(splitLine, int.Parse);
                yield return new PrisonerTestCase(numbers[0], numbers[1], numbers[2]);
            }
        }
    }

    public class PrisonerTestCase
    {
        public int PrisonerCount { get; set; }
        public int SweetCount { get; set; }
        public int PrisonerId { get; set; }

        public PrisonerTestCase(int prisonerCount, int sweetCount, int prisonerId)
        {
            PrisonerCount = prisonerCount;
            SweetCount = sweetCount;
            PrisonerId = prisonerId;
        }
    }
}
