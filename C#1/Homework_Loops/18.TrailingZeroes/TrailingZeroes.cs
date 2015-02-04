/*  Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000.*/

using System;
class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter factoriel base:");
        ulong facBase = ulong.Parse(Console.ReadLine());
        ulong factorsOfFive = 5;
        ulong trailingZeroes = facBase / factorsOfFive;
        ulong sumZeroes = trailingZeroes;

        while (trailingZeroes > 1)
        {
            factorsOfFive *= 5;
            trailingZeroes = facBase / factorsOfFive;
            sumZeroes += trailingZeroes;
        }

        Console.WriteLine("Trailing zeroes in {0}! are:{1}", facBase, sumZeroes);


    }
}