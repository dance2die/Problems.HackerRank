using System;
using System.Collections.Generic;

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

INPUT:
6 3 4 4 6 4 5 3 4 3 6 5 4 6 7 1 3 4 2 5 6 1 5 1 7 2
nrdyluacvr
OUTPUT: 70

INPUT:
6 5 7 3 6 7 3 4 4 2 3 7 1 3 7 4 6 1 2 4 3 3 1 1 3 5
zbkkfhwplj
OUTPUT: 70
*/
            int area = GetArea(heights, word);
            Console.WriteLine(area);
        }

        private static int GetArea(int[] heights, string word)
        {
            // (int)'a' - 96 = 1, (int)'b' - 96 = 2, etc.
            const int positionOffset = 96;

            // Fill the look up table for ascii mapping
            Dictionary<char, int> map = new Dictionary<char, int>(heights.Length);
            for (int i = 1; i <= heights.Length; i++)
            {
                map.Add((char)(i + positionOffset), heights[i - 1]);
            }

            int maxHeight = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int height = map[word[i]];
                if (height > maxHeight)
                    maxHeight = height;
            }

            return maxHeight * word.Length;
        }
    }
}
