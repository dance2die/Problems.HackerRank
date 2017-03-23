using System;

/*
INPUT: sample case #1
4
1112
1912
1892
1234
OUTPUT:
1112
1X12
18X2
1234
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
    /// <summary>
    /// Cavity Map
    /// https://www.hackerrank.com/challenges/cavity-map
    /// </summary>
    public class CavityMap
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] matrix = GetMatrix(n);

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            const string cavityValue = "X";
            const int lowestValue = -1;

            Func<string, int> getValue = text =>
            {
                int value;
                bool good = int.TryParse(text, out value);
                return good ? value : lowestValue;
            };

            int outerLength = matrix.GetLength(0);
            int innerLength = matrix.GetLength(1);
            for (int i = 0; i < outerLength; i++)
            {
                for (int j = 0; j < innerLength; j++)
                {
                    int currentValue = int.Parse(matrix[i, j]);

                    if (i == 0 || j == 0 || i == outerLength - 1 || j == innerLength - 1)
                    {
                        Console.Write(currentValue);
                    }
                    else
                    {
                        // Check for left and right values
                        int left = getValue(matrix[i, j - 1]);
                        int right = getValue(matrix[i, j + 1]);

                        // Check for up and down values
                        int up = getValue(matrix[i - 1, j]);
                        int down = getValue(matrix[i + 1, j]);

                        if (currentValue > left && currentValue > right && currentValue > up && currentValue > down)
                            Console.Write(cavityValue);
                        else
                            Console.Write(currentValue);
                    }
                }

                Console.WriteLine();
            }
        }

        private static string[,] GetMatrix(int n)
        {
            string[,] result = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    result[i, j] = line[j].ToString();
                }
            }

            return result;
        }
    }
}
