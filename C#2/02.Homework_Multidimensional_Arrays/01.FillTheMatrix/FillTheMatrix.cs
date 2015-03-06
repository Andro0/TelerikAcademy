//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter matrix dimention:");
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("This is matrix A):");
        int[,] matrix = MatrixA(size);
        PrintMatrix(matrix);
        Console.WriteLine();

        Console.WriteLine("This is matrix B):");
        matrix = MatrixB(size);
        PrintMatrix(matrix);
        Console.WriteLine();

        Console.WriteLine("This is matrix C):");
        matrix = MatrixC(size);
        PrintMatrix(matrix);
        Console.WriteLine();

        Console.WriteLine("This is matrix D):");
        matrix = MatrixD(size);
        PrintMatrix(matrix);
        Console.WriteLine();
    }

    static int[,] MatrixA(int dim)
    {
        int[,] matrix = new int[dim, dim];

        matrix[0, 0] = 1;
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            matrix[0, i] = matrix[0, i - 1] + dim;
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = matrix[i - 1, j] + 1;
            }
        }

        return matrix;
    }

    static int[,] MatrixB(int dim)
    {
        int[,] matrix = new int[dim, dim];
        matrix[0, 0] = 1;

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {
                matrix[0, i] = matrix[0, i - 1] + dim * 2 - 1;
            }
            else
            {
                matrix[0, i] = matrix[0, i - 1] + 1;
            }
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j % 2 == 1)
                {
                    matrix[i, j] = matrix[i - 1, j] - 1;
                }
                else
                {
                    matrix[i, j] = matrix[i - 1, j] + 1;
                }
            }
        }

        return matrix;
    }

    static int[,] MatrixC(int dim)
    {
        int[,] matrix = new int[dim, dim];
        matrix[dim - 1, 0] = 1;
        int counter = 1;
        for (int row = dim - 2; row >= 0; row--)
        {
            matrix[row, 0] = matrix[row + 1, 0] + counter;
            int newRow = row;
            for (int diagonal = 1; diagonal <= counter; diagonal++)
            {
                matrix[newRow + 1, diagonal] = matrix[newRow, diagonal - 1] + 1;
                newRow++;
            }
            counter++;
        }

        matrix[0, dim - 1] = dim * dim;
        int diagonalLength = 2;
        int posX = 1;
        int posY = dim - 1;
        int prevX = 0;
        int prevY = dim - 1;

        for (int i = 1; i < counter - 1; i++)
        {
            for (int j = 1; j <= diagonalLength; j++)
            {
                matrix[posX, posY] = matrix[prevX, prevY] - 1;
                prevX = posX;
                prevY = posY;
                posX--;
                posY--;
            }
            diagonalLength++;
            posX = i + 1;
            posY = dim - 1;
        }

        return matrix;
    }

    static int[,] MatrixD(int dim)
    {
        int[,] matrix = new int[dim, dim];
        int numConcentricSquares = (int)Math.Ceiling((dim) / 2.0);
        int j;
        int sideLength = dim;
        int currNum = 0;

        for (int i = 0; i < numConcentricSquares; i++)
        {
            for (j = 0; j < sideLength; j++)
            {
                matrix[i + j, i] = ++currNum;
            }
            for (j = 1; j < sideLength - 1; j++)
            {
                matrix[dim - 1 - i, i + j] = ++currNum;
            }
                        for (j = sideLength - 1; j > 0; j--)
            {
                matrix[i + j, dim - 1 - i] = ++currNum;
            }
            for (j = sideLength - 1; j > 0; j--)
            {
                matrix[i, i + j] = ++currNum;
            }

            sideLength -= 2;
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, 3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}


