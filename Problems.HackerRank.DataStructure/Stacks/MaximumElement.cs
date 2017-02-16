/*
INPUT:
10
1 97
2
1 20
2
1 26
1 20
2
3
1 91
3
OUTPUT:
26
91

INPUT:

 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.DataStructure.Stacks
{
    /// <summary>
    /// Maximum Element
    /// https://www.hackerrank.com/challenges/maximum-element
    /// </summary>
    public class MaximumElement
    {
        public static void Main(string[] args)
        {
            int queryCount = int.Parse(Console.ReadLine());
            List<Query> queries = GetQueries(queryCount).ToList();

            PrintMaximums3(queries);
        }

        /// <summary>
        /// Uses Java implementation in Discussion section.
        /// </summary>
        private static void PrintMaximums3(List<Query> queries)
        {
            const int lowestMaxValue = 1;
            int maxValue = lowestMaxValue;
            Stack<StackNode> valueStack = new Stack<StackNode>();

            foreach (Query query in queries)
            {
                switch (query.Type)
                {
                    case QueryType.Push:
                        if (!query.Value.HasValue)
                            throw new ArgumentNullException();
                        var value = query.Value.Value;
                        maxValue = Math.Max(value, maxValue);

                        valueStack.Push(new StackNode(value, maxValue));
                        break;
                    case QueryType.Pop:
                        valueStack.Pop();

                        if (valueStack.Count == 0)
                            maxValue = lowestMaxValue;
                        else
                            maxValue = valueStack.Peek().CurrentMaxValue;
                        break;
                    case QueryType.Print:
                        if (valueStack.Count > 0)
                            Console.WriteLine(valueStack.Peek().CurrentMaxValue);
                        break;
                }
            }
        }

        private static void PrintMaximums2(List<Query> queries)
        {
            int maxValue = 1;
            Stack<int> maxValueStack = new Stack<int>(new [] {maxValue});
            Stack<int> valueStack = new Stack<int>();

            foreach (Query query in queries)
            {
                switch (query.Type)
                {
                    case QueryType.Push:
                        if (!query.Value.HasValue)
                            throw new ArgumentNullException();
                        var value = query.Value.Value;

                        if (value > maxValueStack.Peek())
                            maxValueStack.Push(value);

                        valueStack.Push(value);
                        break;
                    case QueryType.Pop:
                        int poppedValue = valueStack.Pop();
                        if (poppedValue == maxValueStack.Peek() && !valueStack.Contains(poppedValue))
                            maxValueStack.Pop();
                        break;
                    case QueryType.Print:
                        Console.WriteLine(maxValueStack.Peek());
                        break;
                }
            }
        }

        private static void PrintMaximums(List<Query> queries)
        {
            // minimum is 1 according to problem description.
            int maximum = 1;
            int previousMinimum = maximum;
            Stack<int> valueStack = new Stack<int>();
            foreach (Query query in queries)
            {
                switch (query.Type)
                {
                    case QueryType.Push:
                        if (!query.Value.HasValue)
                            throw new ArgumentNullException();
                        var value = query.Value.Value;
                        if (value > maximum)
                        {
                            previousMinimum = maximum;
                            maximum = value;
                        }

                        valueStack.Push(value);
                        break;
                    case QueryType.Pop:
                        int poppedValue = valueStack.Pop();
                        if (poppedValue == maximum)
                            maximum = previousMinimum;
                        break;
                    case QueryType.Print:
                        Console.WriteLine(maximum);
                        break;
                }
            }
        }

        private static IEnumerable<Query> GetQueries(int queryCount)
        {
            for (int i = 0; i < queryCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                if (line.Length == 1)
                    yield return new Query((QueryType)int.Parse(line[0]), null);
                else
                    yield return new Query((QueryType)int.Parse(line[0]), Int32.Parse(line[1]));
            }
        }
    }

    public class StackNode
    {
        public int Value { get; set; }
        public int CurrentMaxValue { get; set; }

        public StackNode(int value, int currentMaxValue)
        {
            Value = value;
            CurrentMaxValue = currentMaxValue;
        }
    }

    public class Query
    {
        public QueryType Type { get; set; }
        public int? Value { get; set; }

        public Query(QueryType type, int? value)
        {
            Type = type;
            Value = value;
        }
    }

    public enum QueryType
    {
        Push = 1,
        Pop = 2,
        Print = 3
    }
}
