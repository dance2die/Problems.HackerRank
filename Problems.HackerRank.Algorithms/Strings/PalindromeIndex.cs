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
            List<string> testCases = Enumerable.Range(0, int.Parse(Console.ReadLine()))
                .Select(_ => Console.ReadLine()).ToList();
            PrintPalindromeIndexes(testCases);

            //var testCases = File.ReadAllLines(@".\Strings\PalindromeIndexes_TestCase05.txt");
            //PrintPalindromeIndexes(testCases.Skip(1).ToList());
        }

        private static void PrintPalindromeIndexes(IList<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                Console.WriteLine(GetRemovedIndex4(testCase));
            }
        }

        private static int GetRemovedIndex4(string testCase)
        {
            if (IsPalindrome2(new StringBuilder(testCase))) return -1;

            StringBuilder buffer = new StringBuilder(testCase);
            for (int i = 0; i < testCase.Length; i++)
            {
                if (testCase[i] != testCase[testCase.Length - i - 1])
                {
                    if (IsPalindrome2(buffer.Remove(i, 1)))
                        return i;
                    return testCase.Length - i - 1;
                }
            }

            return -1;
        }

        private static bool IsPalindrome2(StringBuilder buffer)
        {
            int length = buffer.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (buffer[i] != buffer[length - i - 1])
                    return false;
            }

            return true;
        }
        
    }
}
