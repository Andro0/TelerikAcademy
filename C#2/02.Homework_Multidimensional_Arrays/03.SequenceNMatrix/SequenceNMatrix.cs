/*  We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour
    elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceNMatrix
{
    static string[,] matrix;
    static void Main()
    {
        Console.Write("Enter matrix size [N,M] N=");
        int sizeN = int.Parse(Console.ReadLine());
        Console.Write("Enter matrix size [{0},M] M=", sizeN);
        int sizeM = int.Parse(Console.ReadLine());

        matrix = new string[sizeN, sizeM];

        for (int i = 0; i < sizeN; i++)
        {
            Console.Write("Enter elements in row {0} in the same line separated by space:", i);
            string input = Console.ReadLine();
            string[] transformedArray = input.Split(' ');
            for (int j = 0; j < sizeM; j++)
            {
                matrix[i, j] = transformedArray[j];
            }

        }

        Dictionary<string, int> sequence = new Dictionary<string, int>();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int neighbourCounter = LookNeighbours(row, col);
                if (neighbourCounter == 0)
                {
                    if (sequence.ContainsKey(matrix[row, col]))
                    {
                        sequence.Remove(matrix[row, col]);
                    }
                }
                else
                {
                    if (sequence.ContainsKey(matrix[row, col]))
                    {
                        sequence[matrix[row, col]]++;
                    }
                    else
                    {
                        sequence.Add(matrix[row, col], 1);
                    }
                }
            }
        }

        var sortedDict = (from entry in sequence orderby entry.Value ascending select entry)
            .ToDictionary(x => x.Key, x => x.Value);
        KeyValuePair<string, int> element;
        int index = sortedDict.Count - 1;
        element = sortedDict.ElementAt(index);

        int repeats = element.Value;
        string str = element.Key;

        string result = "";
        for (int i = 1; i <= repeats; i++)
        {
            result += str + " ";
        }
        Console.WriteLine("The longest sequence in the array is --->{0}", result);
    }

    private static int LookNeighbours(int x, int y)
    {
        int result = 0;
        for (int row = x - 1; row <= x + 1; row++)
        {
            if (row < 0 || row > matrix.GetLength(0) - 1)
            {
                continue;
            }
            for (int col = y - 1; col <= y + 1; col++)
            {
                if (col < 0 || col > matrix.GetLength(1) - 1 || (row == x && col == y))
                {
                    continue;
                }
                if (matrix[row, col] == matrix[x, y])
                {
                    result++;
                }
            }
        }
        return result;



    }
}