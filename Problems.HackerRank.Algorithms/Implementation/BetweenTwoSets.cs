using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Between Two Sets
    /// https://www.hackerrank.com/challenges/between-two-sets
    /// </summary>
    public class BetweenTwoSets
    {
        public static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, int.Parse);
/*
INPUT:
2 3
2 4
16 32 96
OUTPUT: 3

INPUT:
10 10
100 99 98 97 96 95 94 93 92 91
1 2 3 4 5 6 7 8 9 10
OUTPUT: 0

INPUT:
1 3
2
20 30 12
OUTPUT: 1

INPUT:
3 2
3 9 6
36 72
OUTPUT: 2
*/

            var count = GetBetweenNumberCount(a, b);
            Console.WriteLine(count);
        }



        private static int GetBetweenNumberCount(int[] a, int[] b)
        {
            int aMax = a.Max();
            int bMin = b.Min();

            //// check if all numbers except aMax are factors of aMax.
            //bool isMaxOK = CheckIfRestAreFactorsOfMax(a, aMax);
            //if (!isMaxOK) return 0;
            
            //// check if bMin is a factor of all other numbers
            //bool isMinOK = CheckIfMinIsFactorOfRest(b, bMin);
            //if (!isMinOK) return 0;

            int count = CheckIfRestAreFactorsOfMax(a, aMax) && CheckIfMinIsFactorOfRest(b, aMax) ? 1 : 0;

            //foreach (int aValue in a)
            for (int i = 1; i < bMin; i++)
            {
                var aMulti = i * aMax;
                if (aMulti == aMax) continue;

                if (CheckIfRestAreFactorsOfMax(a, aMulti) && CheckIfMinIsFactorOfRest(b, aMulti))
                    count++;
            }

            return count;
        }

        private static bool CheckIfMinIsFactorOfRest(int[] b, int bMin)
        {
            foreach (var bValue in b.Where(val => val != bMin))
            {
                if (bValue%bMin != 0)
                    return false;
            }
            return true;
        }

        private static bool CheckIfRestAreFactorsOfMax(int[] a, int aMax)
        {
            foreach (var aValue in a.Where(val => val != aMax))
            {
                if (aMax%aValue != 0)
                    return false;
            }
            return true;
        }

        private static int Gcd(int x, int y)
        {
            while (y != 0)
            {
                var temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }
        //private static int GetBetweenNumberCount2(int[] a, int[] b)
        //{
        //    List<int> commonFactors = new List<int>();
        //    var aFactors = GetFactorsIn(a);
        //    var bFactors = GetFactorsIn(b);
        //    commonFactors.AddRange(aFactors);
        //    commonFactors.AddRange(bFactors);
        //    commonFactors = commonFactors.Distinct().ToList();

        //    for (int i = 0; i < commonFactors.Count; i++)
        //    {

        //    }
        //}

        //private static List<int> GetFactorsIn(int[] a)
        //{
        //    List<int> factors = new List<int>();
        //    foreach (int number in a)
        //    {
        //        var tempFactors = GetFactors(number);
        //        factors.AddRange(tempFactors);
        //    }

        //    return factors.Distinct().ToList();
        //}

        ///// <summary>
        ///// http://stackoverflow.com/a/239877/4035
        ///// </summary>
        //public static List<int> GetFactors(int number)
        //{
        //    List<int> factors = new List<int>();
        //    int max = (int)Math.Sqrt(number);  //round down
        //    for (int factor = 1; factor <= max; ++factor)
        //    { //test from 1 to the square root, or the int below it, inclusive.
        //        if (number % factor == 0)
        //        {
        //            factors.Add(factor);
        //            if (factor != number / factor)
        //            { // Don't add the square root twice!  Thanks Jon
        //                factors.Add(number / factor);
        //            }
        //        }
        //    }
        //    return factors;
        //}
    }
}
