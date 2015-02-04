/*  Catalan numbers are calculated by the following formula: (2*n)!/((n+1)!*n!)
    Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). */

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter number n between [1-100]: ");
        int numN = int.Parse(Console.ReadLine());
        BigInteger facUp = 1;
        BigInteger facDown = numN+1;
       
        for (int i = numN+1; i <= 2*numN; i++)
        {
            facUp *= i;
            facDown *= (i - numN);
        }
        Console.WriteLine("Catalan({0})={1}", numN, facUp/facDown);

    }
}
