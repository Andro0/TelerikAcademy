/*  Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality. */

using System;
using System.Linq;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number:");
        int[] binaryArray = Console.ReadLine().ToCharArray().Select(n => (int)char.GetNumericValue(n)).ToArray();
        Array.Reverse(binaryArray);

        int decimalNum = 0;

        for (int i = 0; i < binaryArray.Length; i++)
        {
            decimalNum += binaryArray[i] * (int)Math.Pow(2, i);
        }
        Console.WriteLine("Decimal is:{0}", decimalNum);
           
    }
}
