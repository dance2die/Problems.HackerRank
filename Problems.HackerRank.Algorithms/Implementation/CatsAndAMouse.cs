using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
3
1 2 3
1 3 2
2 1 3
OUTPUT:
Cat B
Mouse C
Cat A
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Cats and a Mouse
    /// https://www.hackerrank.com/challenges/cats-and-a-mouse
    /// </summary>
    public class CatsAndAMouse
    {
        public static void Main(string[] args)
        {
            int testCaseCount = Convert.ToInt32(Console.ReadLine());
            List<CatMouse> testCases = GetTestCases(testCaseCount).ToList();

            List<string> result = GetWinningMouse(testCases).ToList();
            result.ForEach(Console.WriteLine);
        }

        private static IEnumerable<string> GetWinningMouse(List<CatMouse> catMice)
        {
            foreach (CatMouse catMouse in catMice)
            {
                int xDistance = Math.Abs(catMouse.Z - catMouse.X);
                int yDistance = Math.Abs(catMouse.Z - catMouse.Y);
                if (xDistance == yDistance)
                    yield return "Mouse C";
                else if (xDistance > yDistance)
                    yield return "Cat B";
                else
                    yield return "Cat A";
            }
        }

        private static IEnumerable<CatMouse> GetTestCases(int testCaseCount)
        {
            for (int i = 0; i < testCaseCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens[0]);
                int y = Convert.ToInt32(tokens[1]);
                int z = Convert.ToInt32(tokens[2]);

                yield return new CatMouse(x, y, z);
            }
        }
    }

    public class CatMouse
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public CatMouse(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
