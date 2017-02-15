/*
INPUT:
5 3
1 2 100
2 5 100
3 4 100
OUTPUT: 200

INPUT:
4 3
2 3 603
1 1 286
4 4 882
OUTPUT: 882

 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problems.HackerRank.DataStructure.Arrays
{
    /// <summary>
    /// Algorithmic Crush
    /// https://www.hackerrank.com/challenges/crush
    /// </summary>
    public class AlgorithmicCrush
    {
        public static void Main()
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int arraySize = line[0];
            int operationCount = line[1];
            List<Operation> operations = GetOperations(operationCount).ToList();

            long max = GetMaximumAfterOperations(arraySize, operations);
            Console.WriteLine(max);
        }

        private static long GetMaximumAfterOperations(int arraySize, List<Operation> operations)
        {
            // initialize array to 0
            long[] a = Enumerable.Repeat(0, arraySize).Select(value => (long) value).ToArray();

            for (var i = 0; i < operations.Count; i++)
            {
                var operation = operations[i];
                OperateOn(a, operation);
            }

            return a.Max();
        }

        private static void OperateOn(long[] a, Operation operation)
        {
            for (int i = operation.A - 1; i < operation.B; i++)
            {
                a[i] += operation.Value;
            }
        }

        private static IEnumerable<Operation> GetOperations(int operationCount)
        {
            var path = @".\Arrays\AlgorithmicCrushTestCase7.txt";
            // skip header
            string[] lines = File.ReadAllLines(path).Skip(1).ToArray();

            for (int i = 0; i < operationCount; i++)
            {
                //var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var line = Array.ConvertAll(lines[i].Split(' '), int.Parse);
                int a = line[0];
                int b = line[1];
                int value = line[2];

                yield return new Operation(a, b, value);
            }
        }
    }

    public class Operation
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Value { get; set; }

        public Operation(int a, int b, int value)
        {
            A = a;
            B = b;
            Value = value;
        }
    }
}
