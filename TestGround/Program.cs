using System;
using System.Collections.Generic;
using System.Linq;

namespace TestGround
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(new[] {0, 2, 4, 60, 8, 0, 2});
            int[] values = q.ToArray();
            SortedDictionary<int, int> countingArray = new SortedDictionary<int, int>();

            for (int i = 0; i < values.Length; i++)
            {
                var key = values[i];

                if (countingArray.Keys.Contains(key))
                    countingArray[key]++;
                else
                    countingArray.Add(key, 1);
            }

            Console.WriteLine(countingArray);

            // Accumulate
            int total = countingArray[0];
            var keys = countingArray.Keys.ToList();
            for (int i = 1; i < countingArray.Count; i++)
            {
                int key = keys[i];
                int oldCount = countingArray[key];
                countingArray[key] += total;
                total += oldCount;
            }

            Console.WriteLine(countingArray);

            int removedValue = q.Dequeue();
            int addedValue = 1;
            q.Enqueue(addedValue);

            UpdateCountingArray(q, countingArray, removedValue, addedValue);
            Console.WriteLine(countingArray);
        }

        private static void UpdateCountingArray(Queue<int> q, SortedDictionary<int, int> map, int removedValue, int addedValue)
        {
            var valueList = q.ToList();
            for (int i = 0; i < valueList.Count; i++)
            {
                // deal with removed value
                //if ()

                // deal with Added Value
            }

            // Accumulate
            for (int i = 0; i < map.Count; i++)
            {
                
            }

        }
    }

    public class Pair
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public Pair(int key, int value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Key}={Value}";
        }
    }
}
