/*  Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;
class CalculateNXN
{
    static void Main()
    {
        Console.Write("Enter integer number n:");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number x:");
        int numX = int.Parse(Console.ReadLine());
        double sum = 1;
        double numXX = numX;
        double factor = 1;
        for (int i = 1; i <= numN; i++)
        {
            factor *= i;
            sum = sum + factor / numXX;
            numXX *= numX;
        }
        Console.WriteLine("The sum is:{0:f5}", sum);
        
    }
}
