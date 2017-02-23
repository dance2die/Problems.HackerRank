using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
11
middle-Outz
2
OUTPUT:
okffng-Qwvb
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Caesar Cipher
    /// https://www.hackerrank.com/challenges/caesar-cipher-1
    /// </summary>
    public class CaesarCipher
    {
        public static void Main()
        {
            var characterCount = Console.ReadLine();    // ignore
            var text = Console.ReadLine();
            var shiftCount = int.Parse(Console.ReadLine());

            var cipherText = new string(CipherText(text, shiftCount).ToArray());
            Console.WriteLine(cipherText);
        }

        private static IEnumerable<char> CipherText(string text, int shiftCount)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    yield return c;
                }
                else
                {
                    if (char.IsUpper(c))
                        yield return ShiftUpper(c, shiftCount);
                    else
                        yield return ShiftLower(c, shiftCount);
                }
            }
        }

        private const int ALPHABET_COUNT = 26;  // 26 letters
        private static readonly Dictionary<char, int> _lowerCaseMap = 
            Enumerable.Range('a', ALPHABET_COUNT).Select((value, index) =>
                 new
                 {
                     Key = (char)value,
                     Value = index
                 }).ToDictionary(pair => pair.Key, pair => pair.Value);

        private static readonly Dictionary<char, int> _upperCaseMap = 
            Enumerable.Range('A', ALPHABET_COUNT).Select((value, index) =>
                 new
                 {
                     Key = (char)value,
                     Value = index
                 }).ToDictionary(pair => pair.Key, pair => pair.Value);

        private static char ShiftUpper(char c, int shiftCount)
        {
            int newIndex = (_upperCaseMap[c] + shiftCount) % ALPHABET_COUNT;
            return _upperCaseMap.ElementAt(newIndex).Key;
        }

        private static char ShiftLower(char c, int shiftCount)
        {
            int newIndex = (_lowerCaseMap[c] + shiftCount) % ALPHABET_COUNT;
            return _lowerCaseMap.ElementAt(newIndex).Key;
        }

    }
}
