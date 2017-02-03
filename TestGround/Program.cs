using System;
using System.Collections.Generic;
using System.Linq;

namespace TestGround
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(new[] {10, 20, 40, 600, 80, 10, 20});
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
            var keys = countingArray.Keys.ToList();
            int total = countingArray[keys[0]];
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

            UpdateCountingArray(countingArray, removedValue, addedValue);
            Console.WriteLine(countingArray);
        }

        private static void UpdateCountingArray(SortedDictionary<int, int> countingArray, int removedValue, int addedValue)
        {
            var previousKeys = countingArray.Keys.ToList();

            for (int i = 0; i < countingArray.Count; i++)
            {
                // deal with removed value
                if (countingArray.ContainsKey(removedValue))
                {
                    if (countingArray[removedValue] == 0)
                        countingArray.Remove(removedValue);
                    else
                    {
                        for (int j = i; j < previousKeys.Count; j++)
                        {
                            countingArray[previousKeys[j]]--;
                        }
                    }

                    break;
                }
            }

            for (int i = 0; i < countingArray.Count; i++)
            {
                // deal with Added Value
                if (countingArray.ContainsKey(addedValue))
                {
                    for (int k = i; k < previousKeys.Count; k++)
                    {
                        countingArray[previousKeys[k]]++;
                    }
                    break;
                }
                else
                {
                    countingArray.Add(addedValue, 1);
                    int startIndex = countingArray[addedValue];

                    var nextKeys = countingArray.Keys.ToList();
                    for (int k = startIndex; k < nextKeys.Count; k++)
                    {
                        countingArray[nextKeys[k]]++;
                    }
                    break;
                }
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
