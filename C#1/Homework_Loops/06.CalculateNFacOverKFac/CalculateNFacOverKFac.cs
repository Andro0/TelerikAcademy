/*  Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.*/

using System;
using System.Numerics;
class CalculateNFacOverKFac
{
    static void Main()
    {
        Console.Write("Enter number n between (1-100): ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter number k between (1-{0}): ", numN);
        int numK = int.Parse(Console.ReadLine());
        BigInteger res = 1;
        for (int i = numK + 1; i <= numN; i++)
        {
            res *= (BigInteger)i;
        }
        Console.WriteLine("n!/k!={0}", res);
    }
}
