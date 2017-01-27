using System;
using System.Collections.Generic;
using System.Linq;

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

                var text = i < lineCount / 2 ? "-" : split[1];
                values.Add(i, new Line(int.Parse(split[0]), text));
            }

            //Console.WriteLine(values);

            var countTable = GetCountTable(values);
            PrintCountTable(countTable);
        }

        private static void PrintCountTable(IOrderedEnumerable<KeyValuePair<int, Line>> countTable)
        {
            foreach (KeyValuePair<int, Line> pair in countTable)
            {
                Console.Write("{0} ", pair.Value.Text);
            }
        }

        /// <summary>
        /// Cheating with LINQ.
        /// </summary>
        //private static Dictionary<int, Line> GetCountTable(Dictionary<int, Line> values)
        private static IOrderedEnumerable<KeyValuePair<int, Line>> GetCountTable(Dictionary<int, Line> values)
        {
            return values
                .OrderBy(pair => pair.Value.Position)
                .ThenBy(pair => pair.Key);
            //.ToDictionary(pair => pair.Key, pair => pair.Value);
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
