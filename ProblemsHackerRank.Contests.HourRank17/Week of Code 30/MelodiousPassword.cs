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
                        foreach (string consonant in GetV(n - 1))
                        {
                            yield return consonant + vowel;
                        }
                    }
                }
                else
                {
                    foreach (var consonant in _consonants)
                    {
                        foreach (string v in GetV(n - 1))
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

        private static void PrintPasswords(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintPassword(i);
            }
        }

        private static void PrintPassword(int n)
        {
            PrintVowelStart(n);
            PrintConsonantStart(n);
        }

        private static bool IsEven(int n)
        {
            return n % 2 == 0;
        }


        private static readonly string[][] vmap =
        {
            new[] {"a", "e", "i", "o", "u"},
            new[] {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"},
        };

        private static readonly string[][] cmap =
        {
            new[] {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"},
            new[] {"a", "e", "i", "o", "u"},
        };

        private static void PrintVowelStart(int n)
        {
            List<string> buffers = new List<string>(vmap[0].Length);

            for (int i = 0; i < vmap[0].Length; i++)
            {
                string[] lines = Enumerable.Repeat("", vmap[0].Length).ToArray();
                for (int j = 0; j <= n; j++)
                {
                    if (IsEven(j))
                    {
                        for (int k = 0; k < vmap[0].Length; k++)
                        {
                            lines[k] += vmap[0][i];
                        }
                    }
                    else
                    {
                        for (int k = 0; k < vmap[1].Length; k++)
                        {
                            lines[k] += vmap[1][i];
                        }
                    }
                }

                buffers.AddRange(lines);


                //for (int i = 0; i <= n; i++)
                //{
                //    if (IsEven(i))
                //    {
                //        for (int j = 0; j < vmap[0].Length; j++)
                //        {
                //            buffer.Append(vmap[0][j]);
                //        }
                //    }
                //    else
                //    {
                //        for (int j = 0; j < vmap[1].Length; j++)
                //        {
                //            buffer.Append(vmap[1][j]);
                //        }
                //    }

                //    buffer.AppendLine();

            }
            buffers.ForEach(Console.WriteLine);
        }

        private static void PrintConsonantStart(int n)
        {
            //StringBuilder buffer = new StringBuilder();
            //for (int i = 0; i <= n; i++)
            //{
            //    if (IsEven(i))
            //    {
            //        for (int j = 0; j < cmap[0].Length; j++)
            //        {
            //            buffer.Append(cmap[0][j]);
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < cmap[1].Length; j++)
            //        {
            //            buffer.Append(cmap[1][j]);
            //        }
            //    }

            //    buffer.AppendLine();
            //}

            //Console.WriteLine(buffer);
        }
    }
}
