using System;
using System.Collections.Generic;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// The Full Counting Sort
    /// https://www.hackerrank.com/challenges/countingsort4
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class TheFullCountingSort
    {
        public static void Main(string[] args)
        {
            var lineCount = int.Parse(Console.ReadLine());

            Dictionary<int, Line> values = new Dictionary<int, Line>(lineCount);
            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine();
                string[] split = line.Split(' ');
                values.Add(i, new Line(int.Parse(split[0]), split[1]));
            }

            //Console.WriteLine(values);
        }
    }

    public class Line
    {
        public int Position { get; set; }
        public string Text { get; set; }

        public Line(int position, string text)
        {
            Position = position;
            Text = text;
        }
    }
}
