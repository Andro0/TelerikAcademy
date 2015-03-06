/*  Write a program that shows the binary representation of given 16-bit signed integer 
    number (the C# type short). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter integer number from {0} to {1} N=", short.MinValue, short.MaxValue);
        short shortNum = short.Parse(Console.ReadLine());
        short numberShort = shortNum;

        int[] numberInBinary = new int[16];

        if (numberShort >= 0)
        {
            DecToBinShort(numberShort, numberInBinary);
        }
        else
        {
            numberInBinary[0] = 1;
            numberShort = (short)((short.MaxValue + 1) + numberShort);
            DecToBinShort(numberShort, numberInBinary);
        }

        Console.Write("{0} is represented in binary short as:", shortNum);
        PrintBinaryNumber(numberInBinary);
    }

    private static void DecToBinShort(short decimalNumber, int[] numberInBinary)
    {
        int currentPossiton = numberInBinary.Length - 1;
        while (decimalNumber != 0)
        {
            if ((decimalNumber % 2) != 0)
            {
                numberInBinary[currentPossiton] = 1;
            }
            decimalNumber >>= 1;
            currentPossiton--;
        }
    }
    private static void PrintBinaryNumber(int[] numberInBinary)
    {
        for (int i = 0; i < numberInBinary.Length; i++)
        {
            Console.Write(numberInBinary[i]);
            if (i == 7)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }


}
