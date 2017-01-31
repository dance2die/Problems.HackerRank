using System;

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

            var expenditures = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


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

            int count = GetFraudulentActivityCounts(days, expenditures);
            Console.WriteLine(count);
        }

        private static int GetFraudulentActivityCounts(int days, int[] expenditures)
        {
            int fraudulentCount = 0;

            for (int i = days; i < expenditures.Length; i++)
            {
                var sourceIndex = i - days;
                int[] lastNDayExpenditures = GetLastNDayExpenditures(days, expenditures, sourceIndex);
                double median = GetMedian(lastNDayExpenditures);

                if (2 * median <= expenditures[i])
                    fraudulentCount++;
            }

            return fraudulentCount;
        }

        private static double GetMedian(int[] a)
        {
            var copy = a.Clone() as int[];
            Array.Sort(copy);

            Func<int, bool> isOdd = value => value % 2 == 1;
            var halfIndex = copy.Length / 2;

            if (isOdd(copy.Length))
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

        private static int[] GetLastNDayExpenditures(int days, int[] expenditures, int sourceIndex)
        {
            int[] lastNDayExpenditures = new int[days];
            Array.Copy(expenditures, sourceIndex, lastNDayExpenditures, 0, days);
            return lastNDayExpenditures;
        }
    }
}
