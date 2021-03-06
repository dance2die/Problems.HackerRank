﻿using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
5 3
250 501 5000 5 4
0 4 5 0
0 4 10 0
0 4 3 2
OUTPUT:
3
2
2
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_30
{
    /// <summary>
    /// Range Modular Queries
    /// https://www.hackerrank.com/contests/w30/challenges/range-modular-queries
    /// </summary>
    public class RangeModularQueries
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int q = Convert.ToInt32(tokens_n[1]);
            string[] temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(temp, int.Parse);

            List<Query> queries = GetQueries(q).ToList();
            List<int> matchCounts = GetMatchCounts(a, queries).ToList();
            matchCounts.ForEach(Console.WriteLine);
        }

        private static IEnumerable<int> GetMatchCounts(int[] a, List<Query> queries)
        {
            foreach (Query query in queries)
            {
                yield return GetMatchCount(a, query);
            }
        }

        private static int GetMatchCount(int[] a, Query query)
        {
            int count = 0;

            for (int i = query.Left; i <= query.Right; i++)
            {
                if (a[i] % query.X == query.Y)
                    count++;
            }

            return count;
        }

        private static IEnumerable<Query> GetQueries(int q)
        {

            for (int i = 0; i < q; i++)
            {
                string[] tokens_left = Console.ReadLine().Split(' ');
                int left = Convert.ToInt32(tokens_left[0]);
                int right = Convert.ToInt32(tokens_left[1]);
                int x = Convert.ToInt32(tokens_left[2]);
                int y = Convert.ToInt32(tokens_left[3]);

                yield return new Query(left, right, x, y);
            }
        }
    }


    internal class Query
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Query(int left, int right, int x, int y)
        {
            Left = left;
            Right = right;
            X = x;
            Y = y;
        }
    }
}
