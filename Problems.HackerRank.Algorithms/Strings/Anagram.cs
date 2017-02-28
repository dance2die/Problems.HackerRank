using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
6
aaabbb
ab
abc
mnop
xyyx
xaxbbbxx
OUTPUT:
3
1
-1
2
0
1

INPUT:
10
csgokgibmftzeozyadcofpouaerckbbpwhdg
njdtcezqezsjbgotwjtacwngzecihkxvtaqxepnkqiusoklnvepyceebiijqsinnkfkpu
bkhxeyirnfycfchjeptphnawckbmbxodkxcoxkiksinxkwjqncgxqgtusxhuuxxeuzvsmfegntdxpmofrwcjexd
umqrjpxgrsadzejoyompdcwuaydewicsvvjgkhmbbmgbtr
tgdklhhfhhkndsswpnhwzokbqzjtsdknlqxwxgbhonwtforxdztdpdghcpawsnjdd
bcrclfpizxyswerphjupqzgtxbghglsinjmbrejsdjkzneqwnkndluwjvesdpkl
vygmcrefcpgqtwoiicnuykdtqvwihkpcixpmottqk
ifvznddbxbncu
zsngccjmzyapttiessjprzvuauvnxrswmgdokodkodbhxjnrczjvyeqaynnxfhurnzhynkkdqlm
xagzbrwbvmbwcqtjxnanojldwxgmkvbhxjiybfzytcuxsogpdicuspxoogczbfiyqtyta
OUTPUT:
8
-1
-1
10
-1
-1
-1
-1
-1
-1
 */
namespace Problems.HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Anagram 
    /// https://www.hackerrank.com/challenges/anagram
    /// </summary>
    public class Anagram
    {
        private const int NOT_POSSIBLE = -1;

        public static void Main(string[] args)
        {
            List<string> testCases = 
                Enumerable.Range(0, int.Parse(Console.ReadLine()))
                .Select(_ => Console.ReadLine()).ToList();
            PrintResults(testCases);
        }

        private static void PrintResults(List<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                int changeCount = GetChangeCountForAnagram2(testCase);
                Console.WriteLine(changeCount);
            }
        }

        private static int GetChangeCountForAnagram2(string testCase)
        {
            if (IsLengthOdd(testCase)) return NOT_POSSIBLE;

            // Parse test case for left and right texts
            int middleIndex = testCase.Length / 2;
            var left = testCase.Substring(0, middleIndex);
            var right = testCase.Substring(middleIndex);

            int total = 0;
            foreach (var c in right)
            {
                int index = left.IndexOf(c);
                if (index >= 0)
                {
                    left = left.Remove(index, 1);
                    total++;
                }
            }

            return total;
        }

        private static int GetChangeCountForAnagram(string testCase)
        {
            if (IsLengthOdd(testCase)) return NOT_POSSIBLE;

            // Parse test case for left and right texts
            int middleIndex = testCase.Length / 2;
            var left = testCase.Substring(0, middleIndex).ToCharArray();
            var right = testCase.Substring(middleIndex).ToCharArray();

            Array.Sort(left);
            Array.Sort(right);
            if (left == right) return 0;

            int total = 0;
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                    total++;
            }

            return total;
        }

        private static bool IsLengthOdd(string text)
        {
            return text.Length % 2 == 1;
        }
    }
}
