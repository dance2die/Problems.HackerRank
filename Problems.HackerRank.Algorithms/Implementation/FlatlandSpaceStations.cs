using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
INPUT:
5 2
0 4
OUTPUT: 2

INPUT:
6 6
0 1 2 4 3 5
OUTPUT: 0
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Flatland Space Stations
    /// https://www.hackerrank.com/challenges/flatland-space-stations
    /// </summary>
    public class FlatlandSpaceStations
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int cityCount = int.Parse(firstLine[0]);
            int spaceStationCount = int.Parse(firstLine[1]);
            var spaceStationIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //string[] lines = File.ReadAllLines(@".\implementation\FlatlandSpaceStations_data15.txt");
            //string[] firstLine = lines[0].Split(' ');
            //int cityCount = int.Parse(firstLine[0]);
            //int spaceStationCount = int.Parse(firstLine[1]);
            //var spaceStationIndexes = lines[1].Split(' ').Select(int.Parse).ToList();

            int maxDistance = GetMaximumDistance(cityCount, spaceStationIndexes);
            Console.WriteLine(maxDistance);
        }

        private static int GetMaximumDistance(int cityCount, IList<int> spaceStationIndexes)
        {
            Dictionary<int, bool> stationMap = GetSpaceStationMap(cityCount, spaceStationIndexes);

            int maxDistance = 0;
            for (int i = 0; i < cityCount; i++)
            {
                int distance = GetMinimumDistance(i, stationMap);
                if (distance > maxDistance)
                    maxDistance = distance;
            }

            return maxDistance;
        }

        private static Dictionary<int, bool> GetSpaceStationMap(int cityCount, IList<int> spaceStationIndexes)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>(cityCount);
            for (int i = 0; i < cityCount; i++)
            {
                map.Add(i, false);
            }

            foreach (int spaceStationIndex in spaceStationIndexes)
            {
                map[spaceStationIndex] = true;
            }

            return map;
        }

        private static int GetMinimumDistance(int i, Dictionary<int, bool> spaceStationMap)
        {
            //int minDistance = int.MaxValue;
            //foreach (var spaceStationIndex in spaceStationIndexes)
            //{
            //    int distance = Math.Abs(spaceStationIndex - i);
            //    if (distance < minDistance)
            //        minDistance = distance;
            //}
            //return minDistance;

            Tuple<int?, int?> surroundingSpaceStations = GetSurroundingSpaceStations(i, spaceStationMap);
            int previousDistance = i - surroundingSpaceStations.Item1 ?? 0;
            int nextDistance = surroundingSpaceStations.Item2 - i ?? 0;
            return Math.Min(previousDistance, nextDistance);
        }

        private static Tuple<int?, int?> GetSurroundingSpaceStations(int i, Dictionary<int, bool> spaceStationMap)
        {
            //int? leftIndex = null;
            //for (int j = i; j >= 0; j--)
            //{
            //    if (spaceStationMap[j])
            //    {
            //        leftIndex = j;
            //        break;
            //    }
            //}

            //int? rightIndex = null;
            //int upto = spaceStationMap.Max(pair => pair.Key);
            //for (int j = i; j <= upto; j++)
            //{
            //    if (spaceStationMap[j])
            //    {
            //        rightIndex = j;
            //        break;
            //    }
            //}

            int? leftIndex = spaceStationMap.Where(pair => pair.Value && pair.Key <= i).DefaultIfEmpty().Max(pair => pair.Key);
            int? rightIndex = spaceStationMap.Where(pair => pair.Value && pair.Key >= i).DefaultIfEmpty().Min(pair => pair.Key);

            return Tuple.Create(leftIndex, rightIndex);
        }
    }
}
