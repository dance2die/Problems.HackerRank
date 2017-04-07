using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
4
73
67
38
33
OUTPUT:
75
67
40
33
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Grading Students
    /// https://www.hackerrank.com/challenges/grading
    /// </summary>
    public class GradingStudents
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> grades = GetGrades(n).ToList();
            List<int> finalGrades = GetFinalGrades(grades).ToList();

            finalGrades.ForEach(Console.WriteLine);
        }

        private static IEnumerable<int> GetFinalGrades(List<int> grades)
        {
            foreach (int grade in grades)
            {
                yield return GetFinalGrade(grade);
            }
        }

        private static int GetFinalGrade(int grade)
        {
            // edge cases
            if (grade < 38) return grade;
            if (grade >= 98) return 100;

            int nextGrade = GetNextGrade(grade);
            if (nextGrade - grade < 3)
                return nextGrade;
            return grade;
        }

        private static int GetNextGrade(int grade)
        {
            int mod = grade % 5;
            if (mod >= 3)
                return grade + (5 - mod);
            return grade;
        }

        private static IEnumerable<int> GetGrades(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
