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
 */

using System;
using System.Collections;
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

            PrintMaximums(queries);
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
