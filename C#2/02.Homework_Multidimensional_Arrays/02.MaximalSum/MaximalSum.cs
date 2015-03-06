/*  Write a program that reads a rectangular matrix of size N x M and finds in it the square
    3 x 3 that has maximal sum of its elements. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter matrix size [N,M] N=");
        int sizeN = int.Parse(Console.ReadLine());
        Console.Write("Enter matrix size [{0},M] M=", sizeN);
        int sizeM = int.Parse(Console.ReadLine());
        int[,] matrix = new int[sizeN, sizeM];

        for (int i = 0; i < sizeN; i++)
        {
            Console.Write("Enter elements in row {0} in the same line separated by space:", i);
            string input = Console.ReadLine();
            string[] transformation = input.Split(' ');
            for (int j = 0; j < sizeM; j++)
            {
                matrix[i, j] = int.Parse(transformation[j]);
            }
        }

        int currentSum = 0;
        int maxSum = 0;
        int maxSquareX = 0;
        int maxSquareY = 0;

        for (int i = 0; i < sizeN - 2; i++)
        {
            for (int j = 0; j < sizeM - 2; j++)
            {
                for (int i2 = i; i2 < i + 3; i2++)
                {
                    for (int j2 = j; j2 < j + 3; j2++)
                    {
                        currentSum += matrix[i2, j2];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSquareX = j;
                    maxSquareY = i;
                }
                currentSum = 0;
            }
        }
        for (int i2 = maxSquareY; i2 < maxSquareY + 3; i2++)
        {
            for (int j2 = maxSquareX; j2 < maxSquareX + 3; j2++)
            {
                Console.Write(matrix[i2, j2] + " ");
            }
            Console.WriteLine();
        }
    }
}