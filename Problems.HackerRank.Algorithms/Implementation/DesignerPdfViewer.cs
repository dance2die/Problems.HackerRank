using System;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Designer PDF Viewer
    /// https://www.hackerrank.com/challenges/designer-pdf-viewer
    /// </summary>
    public class DesignerPdfViewer
    {
        public static void Main(string[] args)
        {
            string[] heightText = Console.ReadLine().Split(' ');
            int[] heights = Array.ConvertAll(heightText, int.Parse);
            string word = Console.ReadLine();
/*
INPUT:
1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5
abc
OUTPUT: 9
*/
            int area = GetArea(heights, word);
            Console.WriteLine(area);
        }

        private static int GetArea(int[] heights, string word)
        {
            return -1;
        }
    }
}
