/*  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
    and prints a matrix like in the examples below. Use two nested loops.
    Examples:

        n = 2   matrix      n = 3   matrix      n = 4   matrix
                1 2                 1 2 3               1 2 3 4
                2 3                 2 3 4               2 3 4 5
                                    3 4 5               3 4 5 6
                                                        4 5 6 7  */

using System;
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter number n between [1-20]: ");
        int numN = int.Parse(Console.ReadLine());
        for (int row = 1; row <= numN; row++)
        {
            for (int col = row; col < numN + row; col++)
            {
                if (col > 0 && col < 10)
                {
                    Console.Write("{0}  ", col);
                }
                else
                {
                    Console.Write("{0} ", col);
                }
            }
            Console.WriteLine();
        }
    }
}
