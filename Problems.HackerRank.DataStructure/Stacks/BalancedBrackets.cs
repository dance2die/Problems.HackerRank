using System;
using System.Collections.Generic;
using System.Linq;

/*
INPUT:
3
{[()]}
{[(])}
{{[[(())]]}}
OUTPUT:
YES
NO
YES

INPUT:
6
}][}}(}][))]
[](){()}
()
({}([][]))[]()
{)[](}]}]}))}(())(
([[)
OUTPUT:
NO
YES
YES
YES
NO
NO
 */
namespace Problems.HackerRank.DataStructure.Stacks
{
    /// <summary>
    /// Balanced Brackets
    /// https://www.hackerrank.com/challenges/balanced-brackets
    /// </summary>
    public class BalancedBrackets
    {
        public static void Main()
        {
            int caseCount = Convert.ToInt32(Console.ReadLine());
            List<string> testCases = GetTestCases(caseCount).ToList();

            PrintMatchingBrackets(testCases);
        }

        private static void PrintMatchingBrackets(List<string> testCases)
        {
            foreach (string testCase in testCases)
            {
                Console.WriteLine(HasMatchingBrackets(testCase) ? "YES" : "NO");
            }
        }

        private static bool HasMatchingBrackets(string testCase)
        {
            // Matching brackets should have even number of brackets.
            Func<string, bool> hasOddLength = text => text.Length % 2 == 1;
            if (hasOddLength(testCase)) return false;

            var openingBracketMap = GetOpeningBracketMap();
            var closingBracketMap = GetClosingBracketMap();

            Func<char, bool> isOpeningBracket = c => openingBracketMap.Keys.Contains(c);
            Func<char, bool> isClosingBracket = c => closingBracketMap.Keys.Contains(c);

            var stackSize = testCase.Length / 2;
            Stack<char> stack = new Stack<char>(stackSize);
            Func<char, bool> isLastOneInStackMatching = c => stack.Peek() == closingBracketMap[c];
            
            foreach (char c in testCase)
            {
                if (isOpeningBracket(c))
                    stack.Push(c);

                if (IsStackEmpty(stack) && isClosingBracket(c))
                    return false;

                if (isClosingBracket(c) && isLastOneInStackMatching(c))
                    stack.Pop();
            }

            return IsStackEmpty(stack);
        }

        private static bool IsStackEmpty(Stack<char> stack)
        {
            return stack.Count == 0;
        }

        private static Dictionary<char, char> GetOpeningBracketMap()
        {
            return new Dictionary<char, char>
            {
                { '{', '}' },
                { '[', ']' },
                { '(', ')' },
            };
        }
        private static Dictionary<char, char> GetClosingBracketMap()
        {
            return new Dictionary<char, char>
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' },
            };
        }

        private static IEnumerable<string> GetTestCases(int caseCount)
        {
            for (int i = 0; i < caseCount; i++)
            {
                yield return Console.ReadLine();
            }
        }
    }
}
