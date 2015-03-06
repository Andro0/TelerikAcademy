//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number:");
        string number = Console.ReadLine();
        Console.WriteLine(HexToDec(number));
    }

    static long HexToDec(string hex)
    {
        long decNumber = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            int digit = 0;
            if (hex[i] >= '0' && hex[i] <= '9')
            {
                digit = hex[i] - '0';
            }
            else if (hex[i] >= 'A' && hex[i] <= 'F')
            {
                digit = hex[i] - 'A' + 10;
            }
            decNumber = decNumber + digit * (long)Math.Pow(16, hex.Length - i - 1);
        }

        return decNumber;
    }
}
