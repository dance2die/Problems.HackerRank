﻿/*
INPUT:
We promptly judged antique ivory buckles for the next prize
OUTPUT: pangram

INPUT:
We promptly judged antique ivory buckles for the prize
OUTPUT: not pangram
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Pangrams
    /// https://www.hackerrank.com/challenges/pangrams
    /// </summary>
    public class Pangrams
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintPangramness(text);
        }

        private const int ALPHABET_COUNT = 26;

        private static void PrintPangramness(string text)
        {
            Console.WriteLine(IsPangram(text) ? "pangram" : "not pangram");
        }

        private static bool IsPangram(string text)
        {
            HashSet<char> map = GetAlphabetMap();
            bool[] flags = Enumerable.Repeat(false, ALPHABET_COUNT).ToArray();

            foreach (var c in text)
            {
                if (map.Contains(c))
                {
                    int flagIndex = GetFlagIndex(c);
                    flags[flagIndex] = true;
                }
            }

            return flags.All(flag => flag);
        }

        private static int GetFlagIndex(char c)
        {
            return char.ToUpper(c) % 'A';
        }

        private static HashSet<char> GetAlphabetMap()
        {
            // offset between lower case letter and a capital one
            // 'a' - 'A' = 32
            const int offset = 32;
            int firstValue = 'A';
            HashSet<char> result = new HashSet<char>();

            for (int i = 0; i < ALPHABET_COUNT; i++)
            {
                char capitalLetter = (char) (firstValue + i);
                char lowerCaseLetter = (char) (firstValue + i + offset);
                result.Add(capitalLetter);
                result.Add(lowerCaseLetter);
            }

            return result;
        }
    }
}
