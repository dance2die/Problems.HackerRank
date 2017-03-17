using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
5
10 10
1 1 1
5 9
2 3 4
3 6
9 1 1
7 7
4 2 1
3 3
1 9 2
OUTPUT:
20
37
12
35
12
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Taum and B'day
    /// https://www.hackerrank.com/challenges/taum-and-bday
    /// </summary>
    public class TaumAndBday
    {
        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            var queries = GetQueries(t);
            List<long> output = GetQueryOutputs(queries).ToList();

            output.ForEach(Console.WriteLine);
        }

        private static IEnumerable<long> GetQueryOutputs(IEnumerable<Query> queries)
        {
            foreach (Query query in queries)
            {
                yield return GetQueryOutput(query);
            }
        }

        private static long GetQueryOutput(Query query)
        {
            long bPrice = GetPrice(query.X, query.Y, query.Z);
            long wPrice = GetPrice(query.Y, query.X, query.Z);

            return (query.B * bPrice) + (query.W * wPrice);
        }

        private static long GetPrice(long ballPrice, long otherBallPrice, long conversionPrice)
        {
            var otherPrice = otherBallPrice + conversionPrice;
            if (ballPrice > otherPrice)
                return otherPrice;
            return ballPrice;
        }

        private static IEnumerable<Query> GetQueries(int t)
        {
            for (int i = 0; i < t; i++)
            {
                string[] tokens_b = Console.ReadLine().Split(' ');
                long b = Convert.ToInt64(tokens_b[0]);
                long w = Convert.ToInt64(tokens_b[1]);
                string[] tokens_x = Console.ReadLine().Split(' ');
                long x = Convert.ToInt64(tokens_x[0]);
                long y = Convert.ToInt64(tokens_x[1]);
                long z = Convert.ToInt64(tokens_x[2]);

                yield return new Query(b, w, x, y, z);
            }
        }
    }

    internal class Query
    {
        public long B { get; set; }
        public long W { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }

        public Query(long b, long w, long x, long y, long z)
        {
            B = b;
            W = w;
            X = x;
            Y = y;
            Z = z;
        }
    }
}
