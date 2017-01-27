using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Counting Sort 3
    /// https://www.hackerrank.com/challenges/countingsort3
    /// from https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class CountingSort3
    {
        public static void Main(string[] args)
        {
            var lineCount = int.Parse(Console.ReadLine());

            List<int> values = new List<int>(lineCount);
            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine();
                values.Add(int.Parse(line.Split(' ')[0]));
            }


            //Console.WriteLine(values);


/*
INPUT:
10
4 that
3 be
0 to
1 be
5 question
1 or
2 not
4 is
2 to
4 the
 
OUTPUT:
1 3 5 6 9 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 
*/   
        }
    }
}
