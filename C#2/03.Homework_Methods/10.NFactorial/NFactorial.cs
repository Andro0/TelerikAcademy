/*  Write a program to calculate n! for each n in the range [1..100].
    Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


class NFactorial
{
    static void Main()
    {
        Console.Write("Enter integer between [1 ... 100] n=");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}! = {1}", number, Factorial(number));
    }

    static BigInteger Multiplication(BigInteger number, int multiplier)
    {
        List<int> digitsNumber = new List<int>();
        while (number != 0)
        {
            digitsNumber.Add((int)(number % 10));
            number /= 10;
        }
        int[] digitsOfNumber = new int[digitsNumber.Count];

        digitsNumber.CopyTo(digitsOfNumber);

        List<BigInteger> result = new List<BigInteger>();
        int oneOnMind = 0;
        for (int i = 0; i < digitsNumber.Count; i++)
        {
            result.Add((int)((digitsOfNumber[i] * multiplier + oneOnMind) % 10));
            oneOnMind = (digitsOfNumber[i] * multiplier + oneOnMind) / 10;
        }

        if (oneOnMind > 0)
        {
            result.Add(oneOnMind);
        }

        result.Reverse(0, result.Count);
        BigInteger output = BigInteger.Parse(string.Join("", result));
        return output;
    }

    static BigInteger Factorial(int facBase)
    {
        BigInteger result = 1;
        for (int i = 1; i <= facBase; i++)
        {
            result = Multiplication(result, i);
        }
        return result;
    }

}
