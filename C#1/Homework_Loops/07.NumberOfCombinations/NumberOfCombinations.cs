/*  Write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
    Try to use only two loops. */

using System;
using System.Numerics;
class NumberOfCombinations
{
    static void Main()
    {
        Console.Write("Enter number n between (1-100): ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter number k between (1-{0}): ", numN);
        int numK = int.Parse(Console.ReadLine());
        BigInteger facUp = 1;
        BigInteger facDown = 1;

        for (int i = numK + 1; i <= numN; i++)
        {
            facUp *= i;
            facDown *= (numN - i + 1);
        }

        Console.WriteLine("n!/(k!*(n-k)!={0}", facUp / facDown);
    }
}
