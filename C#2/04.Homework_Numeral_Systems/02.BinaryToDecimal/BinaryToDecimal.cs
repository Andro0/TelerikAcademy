//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number:");
        string binaryNum = Console.ReadLine();
        Console.WriteLine(BinToDec(binaryNum));
    }
    static long BinToDec(string binaryNum)
    {
        long decNumber = 0;
        for (int i = 0; i < binaryNum.Length; i++)
        {
            int digit = binaryNum[i] - '0';
            decNumber = decNumber + digit * (long)Math.Pow(2, binaryNum.Length - i - 1);
        }

        return decNumber;
    }
}
