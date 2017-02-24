using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
INPUT:
3
aaab
baa
aaa
OUTPUT:
3
0
-1

INPUT:
10
quyjjdcgsvvsgcdjjyq
hgygsvlfwcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcflvsgygh
fgnfnidynhxebxxxfmxixhsruldhsaobhlcggchboashdlurshxixmfxxxbexhnydinfngf
bsyhvwfuesumsehmytqioswvpcbxyolapfywdxeacyuruybhbwxjmrrmjxwbhbyuruycaexdwyfpaloyxbcpwsoiqtymhesmuseufwvhysb
fvyqxqxynewuebtcuqdwyetyqqisappmunmnldmkttkmdlnmnumppasiqyteywdquctbeuwenyxqxqyvf
mmbiefhflbeckaecprwfgmqlydfroxrblulpasumubqhhbvlqpixvvxipqlvbhqbumusaplulbrxorfdylqmgfwrpceakceblfhfeibmm
tpqknkmbgasitnwqrqasvolmevkasccsakvemlosaqrqwntisagbmknkqpt
lhrxvssvxrhl
prcoitfiptvcxrvoalqmfpnqyhrubxspplrftomfehbbhefmotfrlppsxburhyqnpfmqlaorxcvtpiftiocrp
kjowoemiduaaxasnqghxbxkiccikxbxhgqnsaxaaudimeowojk
OUTPUT:
1
8
33
23
25
44
20
-1
14
-1
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Palindrome Index
    /// https://www.hackerrank.com/challenges/palindrome-index
    /// </summary>
    public class PalindromeIndex
    {
        public static void Main()
        {
            //List<string> testCases = Enumerable.Range(0, int.Parse(Console.ReadLine()))
            //    .Select(_ => Console.ReadLine()).ToList();
            //PrintPalindromeIndexes(testCases);

            var testCases = File.ReadAllLines(@".\Strings\PalindromeIndexes_TestCase06.txt");
            PrintPalindromeIndexes(testCases.Skip(1).ToList());
        }

        private static void PrintPalindromeIndexes(IList<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                Console.WriteLine(GetRemovedIndex2(testCase));
            }
        }

        private static int GetRemovedIndex2(string testCase)
        {
            int middleIndex = testCase.Length / 2;
            Func<string, bool> hasEvenLength = str => str.Length % 2 == 0;

            int removedIndex = -1;
            for (int i = 0; i < middleIndex; i++)
            {
                string left = testCase.Substring(0, middleIndex);
                string right = testCase.Substring(hasEvenLength(testCase) ? middleIndex : middleIndex + 1);

                var rightIndex = middleIndex - i - 1;
                if (left[i] != right[rightIndex])
                {


                    //if (rightIndex - 1 >= 0 
                    //    && left[i] == right[rightIndex - 1]
                    //    && left[i + 1] == right[rightIndex])
                    //    return right.Length + rightIndex;
                    //return i;

                    //var rightReversed = new string(right.Reverse().ToArray());
                    //if (rightIndex - 1 >= 0  && i + 1 < middleIndex &&
                    //    //left.Substring(i + 1) == new string(right.Substring(rightIndex + 1).Reverse().ToArray()))
                    //    left.Substring(i + 1) == rightReversed.Substring(i + 1))
                    //    return right.Length + rightIndex;
                    //return i;

                    //if (rightIndex - 1 >= 0 && i + 1 < middleIndex)
                    //    if (IsRestPalindrome(left.Substring(i), right.Substring(0, middleIndex - i - 1)))
                    //        return right.Length + rightIndex;
                    //    if (IsRestPalindrome(left.Substring(i + 1), right.Substring(0, middleIndex - i)))
                    //        return i;
                }
            }

            return removedIndex;
        }

        //private static bool IsRestPalindrome(string left, string right)
        //{
        //    var upto = Math.Min(left.Length, right.Length);
        //    for (int i = 0; i < upto; i++)
        //    {
        //        if (left[i] == right[right.Length - i - 1])
        //            return false;
        //    }
        //    return true;
        //}

        /// <remarks>
        /// Partially copied from TheLoveLetterMystery
        /// </remarks>
        private static int GetRemovedIndex(string testCase)
        {
            if (IsPalindrome(testCase)) return -1;

            char removedChar = '\0';
            var buffer = new StringBuilder(testCase);
            for (int i = 0; i < testCase.Length; i++)
            {
                if (i > 0)
                {
                    buffer.Insert(i - 1, removedChar);
                }

                removedChar = buffer[i];
                if (IsPalindrome(buffer.Remove(i, 1)))
                    return i;
            }

            return -1;
        }

        private static bool IsPalindrome(StringBuilder buffer)
        {
            var testCase = buffer.ToString();
            return testCase == Reverse(testCase);
        }

        private static bool IsPalindrome(string testCase)
        {
            //return testCase == Reverse(testCase);

            int length = testCase.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (testCase[i] != testCase[length - i - 1])
                    return false;
            }
            return true;
        }

        private static string Reverse(StringBuilder buffer)
        {
            return Reverse(buffer.ToString());
        }

        private static string Reverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
