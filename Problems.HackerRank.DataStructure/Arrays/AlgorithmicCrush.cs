/*
INPUT:
5 3
1 2 100
2 5 100
3 4 100
OUTPUT:
200
 */

using System;
using System.Collections.Generic;
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

            int max = GetMaximumAfterOperations(operations);
            Console.WriteLine(max);
        }

        private static int GetMaximumAfterOperations(List<Operation> operations)
        {
            return -1;
        }

        private static IEnumerable<Operation> GetOperations(int operationCount)
        {
            for (int i = 0; i < operationCount; i++)
            {
                var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
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
