using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Fraudulent Activity Notifications
    /// https://www.hackerrank.com/challenges/fraudulent-activity-notifications
    /// </summary>
    public class FraudulentActivityNotifications
    {
        public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int arraySize = int.Parse(firstLine[0]);
            int days = int.Parse(firstLine[1]);

            var secondLine = Console.ReadLine();
            var split = secondLine.Split(' ');
            var expenditures = Array.ConvertAll(split, int.Parse);


            // check out http://www.cs.miami.edu/home/burt/learning/Csc517.091/workbook/countingsort.html
            // for counting sort.
            // Need to utilize "Counting Array" and update only count instead of sorting from begnning

/*
INPUT:
9 5
2 3 4 2 3 6 8 4 5
OUTPUT: 2

INPUT:
5 4
1 2 3 4 4
OUTPUT: 0
*/


            //MedianCalculator calculator = new MedianCalculator(new List<int> {2, 5, 4, 1, 4, 0, 4, 3, 4, 5, 2, 5, 4, 0, 1, 1});
            //MedianCalculator calculator = new MedianCalculator(expenditures.ToList().GetRange(0, days - 1));

            int count = GetFraudulentActivityCounts3(days, expenditures);
            Console.WriteLine(count);
        }

        private static int GetFraudulentActivityCounts3(int days, int[] expenditures)
        {
            // Create a calculator by initializing it with seed expenditures for last N days - 1.
            // for each expenditure starting after Nth day - 1,
            //  Get current element and insert to the calculator queue.
            //  Calculate the median.
            //  if 2 x median <= current element, then increase counter++
            MedianCalculator calculator = new MedianCalculator(expenditures.ToList().GetRange(0, days));

            int fraudulentCount = 0;
            for (int i = days; i < expenditures.Length; i++)
            {
                var currentValue = expenditures[i];
                double median = calculator.GetMedian();

                if (2 * median <= currentValue)
                {
                    fraudulentCount++;
                }

                calculator.Add(currentValue);
            }

            return fraudulentCount;
        }
    }

    internal class MedianCalculator
    {
        private readonly Queue<int> _queue;
        private readonly SortedDictionary<int, int> _countingArray = new SortedDictionary<int, int>();
        private int[] _outputArray;

        public MedianCalculator(List<int> list)
        {
            _queue = new Queue<int>(list);
            InitializeCountingArray();
            UpdateOutputArray();
        }

        private void InitializeCountingArray()
        {
            //var queueArray = _queue.ToList();
            ////_countingArray = new int[queueArray.Length];
            //_countingArray = Enumerable.Repeat(0, queueArray.Max(value => value) + 1).ToList();

            //// Calculate the histogram of key frequencies:
            //for (int i = 0; i < _queue.Count; i++)
            //{
            //    var key = queueArray[i];
            //    _countingArray[key]++;
            //}

            //// Calculate the starting index for each key:
            //int total = 0;
            //for (int i = 0; i < _countingArray.Count; i++)
            //{
            //    //_countingArray[queueArray[i]] += _countingArray[queueArray[i - 1]];
            //    var oldCount = _countingArray[i];
            //    _countingArray[i] += total;
            //    total += oldCount;
            //}

            int[] values = _queue.ToArray();
            for (int i = 0; i < values.Length; i++)
            {
                var key = values[i];

                if (_countingArray.Keys.Contains(key))
                    _countingArray[key]++;
                else
                    _countingArray.Add(key, 1);
            }

            // Accumulate count
            var keys = _countingArray.Keys.ToList();
            int total = _countingArray[keys[0]];
            for (int i = 1; i < _countingArray.Count; i++)
            {
                int key = keys[i];
                int oldCount = _countingArray[key];
                _countingArray[key] += total;
                total += oldCount;
            }
        }

        private void UpdateOutputArray()
        {
            _outputArray = new int[_queue.Count];

            var queueArray = _queue.ToArray();
            var countingArrayCopy = _countingArray.ToDictionary(p => p.Key, p => p.Value);

            for (int i = queueArray.Length - 1; i >= 0; i--)
            {
                var value = queueArray[i];
                var outputIndex = countingArrayCopy[value] - 1;
                countingArrayCopy[value]--;
                _outputArray[outputIndex] = value;
            }
        }

        internal void Add(int value)
        {
            // Dequeue the first element,then enqueue the value.
            var removedValue = _queue.Dequeue();
            _queue.Enqueue(value);
            UpdateCountingArray(removedValue, value);
            UpdateOutputArray();
        }

        private void UpdateCountingArray(int removedValue, int addedValue)
        {
            var previousKeys = _countingArray.Keys.ToList();

            for (int i = 0; i < _countingArray.Count; i++)
            {
                // deal with removed value
                if (_countingArray.ContainsKey(removedValue))
                {
                    var removeIndex = 0;
                    for (int y = 0; y < previousKeys.Count; y++)
                    {
                        if (previousKeys[y] == removedValue)
                        {
                            removeIndex = y;
                            break;
                        }
                    }

                    if (_countingArray[removedValue] == 0)
                    {
                        _countingArray.Remove(removedValue);
                    }
                    //else
                    //{
                    //    for (int j = removeIndex; j < previousKeys.Count; j++)
                    //    {
                    //        _countingArray[previousKeys[j]]--;
                    //    }
                    //}

                    for (int j = removeIndex; j < previousKeys.Count; j++)
                    {
                        _countingArray[previousKeys[j]]--;
                    }

                    break;
                }
            }

            for (int i = 0; i < _countingArray.Count; i++)
            {
                // deal with Added Value
                if (_countingArray.ContainsKey(addedValue))
                {
                    for (int k = i; k < previousKeys.Count; k++)
                    {
                        _countingArray[previousKeys[k]]++;
                    }
                    break;
                }
                else
                {
                    _countingArray.Add(addedValue, 1);
                    var nextKeys = _countingArray.Keys.ToList();

                    int addedIndex = 0;
                    for (int x = 0; x < nextKeys.Count; x++)
                    {
                        if (nextKeys[x] == addedValue)
                        {
                            addedIndex = x;
                            break;
                        }
                    }

                    int previousValue = addedIndex == 0 ? 0 : _countingArray[nextKeys[addedIndex - 1]];
                    int startValue = previousValue + 1;
                    _countingArray[nextKeys[addedIndex]] = startValue;

                    for (int k = addedIndex + 1; k < nextKeys.Count; k++)
                    {
                        _countingArray[nextKeys[k]]++;
                    }
                    break;
                }
            }
        }

        internal double GetMedian()
        {
            var copy = _outputArray.ToList();

            Func<int, bool> isOdd = value => value % 2 == 1;
            var halfIndex = copy.Count / 2;

            if (isOdd(copy.Count))
            {
                return copy[halfIndex];
            }
            else
            {
                // array size is even!
                // get average of two middle values!
                // 1 2 3 4 => (a[halfIndex - 1] + a[halfIndex]) / 2 => (2 + 3) / 2 => 2
                var left = copy[halfIndex - 1];
                var right = copy[halfIndex];
                return (double)(left + right) / 2;
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
