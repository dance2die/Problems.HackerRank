using System;
using System.Text;

/*
INPUT: haveaniceday
OUTPUT: hae and via ecy

INPUT: feedthedog
OUTPUT: fto ehg ee dd

INPUT: chillout
OUTPUT: clu hlt io
 */
namespace Problems.HackerRank.Algorithms.Implementation
{
	/// <summary>
	/// Encryption - https://www.hackerrank.com/challenges/encryption
	/// </summary>
	public class Encryption
	{
		public static void Main()
		{
			string sentence = Console.ReadLine();
			string encryptedSentence = EncryptSentence(sentence);
			Console.WriteLine(encryptedSentence);
		}

		private static string EncryptSentence(string sentence)
		{
			int row = (int)Math.Floor(Math.Sqrt(sentence.Length));
			int col = (int)Math.Ceiling(Math.Sqrt(sentence.Length));
			if (row * col < sentence.Length) row++;

			char[,] matrix = new char[row, col];
			int current = 0;
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					matrix[i, j] = current > sentence.Length - 1 ? ' ' : sentence[current];
					current++;
				}
			}

			StringBuilder buffer = new StringBuilder();
			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					buffer.Append(matrix[j, i] == ' ' ? "" : matrix[j, i].ToString());
				}
				buffer.Append(" ");
			}

			return buffer.ToString();
		}
	}
}
