/*  Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.*/

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number:");
        long decimalNum = long.Parse(Console.ReadLine());
        if (decimalNum == 0)
        {
            Console.WriteLine("0");
        }
        string binaryString = null;

        while (decimalNum != 0)
        {
            binaryString = (decimalNum % 2).ToString() + binaryString;
            decimalNum = decimalNum / 2;
        }

        Console.WriteLine("Binary is:{0}", binaryString);
        
    }
}
