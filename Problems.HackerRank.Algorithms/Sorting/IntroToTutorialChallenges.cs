using System;

namespace Problems.HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// Intro to Tutorial Challenges
    /// https://www.hackerrank.com/challenges/tutorial-intro
    /// </summary>
    public class IntroToTutorialChallenges
    {
        public static void Main(string[] args)
        {
            string value = Console.ReadLine();
            Console.ReadLine(); // ignore array size
            string[] numbers = Console.ReadLine().Split(' ');

/*
INPUT:
4
6
1 4 5 7 9 12

OUTPUT:
1 
*/
            for (var i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i];
                if (number == value)
                    Console.WriteLine(i);
            }
        }
    }
}
