using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

/*
INPUT: 1
OUTPUT:
w
t
v
g
l
o
h
i
x
q
j
r
k
p
a
m
d
e
z
c
n
u
b
f
s
 */
namespace ProblemsHackerRank.Contests.Week_of_Code_30
{
    /// <summary>
    /// Melodious password
    /// https://www.hackerrank.com/contests/w30/challenges/melodious-password
    /// </summary>
    public class MelodiousPassword
    {
        private static readonly string[] _vowels = { "a", "e", "i", "o", "u" };
        private static readonly string[] _consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            PrintPasswords2(n);
        }

        private static void PrintPasswords2(int n)
        {
            List<string> vowels = GetV(n).ToList();
            vowels.ForEach(s =>
            {
                if (s.Length == n)
                    Console.WriteLine(s);
            });

            List<string> consonants = GetC(n).ToList();
            consonants.ForEach(s =>
            {
                if (s.Length == n)
                    Console.WriteLine(s);
            });
        }

        private static IEnumerable<string> GetC(int n)
        {
            if (n == 1)
            {
                foreach (string consonant in _consonants)
                {
                    yield return consonant;
                }
            }
            else
            {
                if (IsEven(n))
                {
                    foreach (string vowel in _vowels)
                    {
                        foreach (string consonant in GetC(n - 1))
                        {
                            yield return consonant + vowel;
                        }
                    }
                }
                else
                {
                    foreach (var consonant in _consonants)
                    {
                        foreach (string v in GetC(n - 1))
                        {
                            yield return v + consonant;
                        }
                    }
                }
            }

        }

        private static IEnumerable<string> GetV(int n)
        {
            if (n == 1)
            {
                foreach (string vowel in _vowels)
                {
                    yield return vowel;
                }
            }
            else
            {
                if (IsEven(n))
                {
                    foreach (var consonant in _consonants)
                    {
                        foreach (string v in GetV(n - 1))
                        {
                            yield return v + consonant;
                        }
                    }
                }
                else
                {
                    foreach (string vowel in _vowels)
                    {
                        foreach (string consonant in GetV(n - 1))
                        {
                            yield return consonant + vowel;
                        }
                    }
                }
            }
        }
        

        private static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
