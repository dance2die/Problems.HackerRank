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
            List<Pair> countingArray = new List<Pair>();

            for (int i = 0; i < values.Length; i++)
            {
                var key = values[i];

                var pair = countingArray.FirstOrDefault(p => p.Key == key);
                if (pair == null)
                    countingArray.Add(new Pair(key, 1));
                else
                    pair.Value++;
            }

            Console.WriteLine(countingArray);

            int removedValue = q.Dequeue();
            int addedValue = 1;
            q.Enqueue(addedValue);

            UpdateCountingArray(q, countingArray, removedValue, addedValue);
            Console.WriteLine(countingArray);
        }

        private static void UpdateCountingArray(Queue<int> q, List<Pair> map, int removedValue, int addedValue)
        {
            var valueList = q.ToList();
            for (int i = 0; i < valueList.Count; i++)
            {
                // deal with removed value
                if (map[i].Key == removedValue)
                {
                    if (map[removedValue].Value == 0)
                        map.RemoveAt(i);
                    else
                        map[removedValue].Value--;
                }

                // deal with Added Value
                if (map.Any(pair => pair.Key == addedValue))
                    map[addedValue].Value++;
                else
                    map.Add(new Pair(addedValue, 1));
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
