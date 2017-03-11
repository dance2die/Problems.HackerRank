using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
6
5 4 4 2 2 8
OUTPUT:
6
4
2
1

INPUT:
8
1 2 3 4 3 3 2 1
OUTPUT:
8
6
4
1
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Cut the sticks
    /// https://www.hackerrank.com/challenges/cut-the-sticks
    /// </summary>
    public class CutTheSticks
    {
        public static void Main(string[] args)
        {
            int stickCount = Convert.ToInt32(Console.ReadLine());
            string[] tempA = Console.ReadLine().Split(' ');
            List<int> sticks = Array.ConvertAll(tempA, int.Parse).ToList();

            List<int> sticksCut = GetSticksCut2(sticks).ToList();
            sticksCut.ForEach(Console.WriteLine);
        }

        private static IEnumerable<int> GetSticksCut2(List<int> sticks)
        {
            var val = Enumerable.Repeat(0, 1001).ToList();
            foreach (int stick in sticks)
            {
                val[stick]++;
            }

            int counter = sticks.Count;
            List<int> ans = new List<int>(counter) {counter};

            foreach (int i in val)
            {
                if (i > 0)
                {
                    counter -= i;
                    if (counter > 0)
                        ans.Add(counter);
                }
            }

            return ans;
        }

        private static IEnumerable<int> GetSticksCut(List<int> sticks)
        {
            while (sticks.Count >= 1)
            {
                if (sticks.Count == 0)
                    yield break;
                yield return sticks.Count;

                int minSize = sticks.Min();
                for (int i = 0; i < sticks.Count; i++)
                {
                    sticks[i] -= minSize;
                    if (sticks[i] <= 0)
                    {
                        sticks.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
    }
}
