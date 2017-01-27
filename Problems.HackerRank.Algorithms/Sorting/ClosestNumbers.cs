using System;

/*
INPUT:
10
-20 -3916237 -357920 -3620601 7374819 -7330761 30 6246457 -6461594 266854 
OUTPUT:
-20 30

INPUT:
12
-20 -3916237 -357920 -3620601 7374819 -7330761 30 6246457 -6461594 266854 -520 -470 
OUTPUT:
-520 -470 -20 30

INPUT:
4
5 4 3 2
OUTPUT:
2 3 3 4 4 5
*/
namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Closest Numbers
    /// https://www.hackerrank.com/challenges/closest-numbers
    /// </summary>
    public class ClosestNumbers
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();     // ignore array size
            var split = Console.ReadLine().Split(' ');
            var values = Array.ConvertAll(split, int.Parse);

        }
    }
}
