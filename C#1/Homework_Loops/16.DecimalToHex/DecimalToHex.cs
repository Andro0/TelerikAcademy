/*  Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.*/

using System;
class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter decimal number:");
        long decimalNum = long.Parse(Console.ReadLine());

        string hexNum = null;

        while (decimalNum > 0)
        {
            long n = decimalNum % 16;
            decimalNum /= 16;
            switch (n)
            {
                case 10: hexNum = "A" + hexNum;
                    break;
                case 11: hexNum = "B" + hexNum;
                    break;
                case 12: hexNum = "C" + hexNum;
                    break;
                case 13: hexNum = "D" + hexNum;
                    break;
                case 14: hexNum = "E" + hexNum;
                    break;
                case 15: hexNum = "F" + hexNum;
                    break;
                default: hexNum = n + hexNum;
                    break;
            }
        }
        Console.WriteLine("The hexadecimal value is: {0}",hexNum);
        
    }
}
