//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number:");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(DecToBin(number));
    }

    static string DecToBin(long number)
    {
        string binNum = "";

        while (number > 0)
        {
            long digit = number % 2;
            binNum = digit + binNum;
            number /= 2;
        }
        return binNum;
    }
}