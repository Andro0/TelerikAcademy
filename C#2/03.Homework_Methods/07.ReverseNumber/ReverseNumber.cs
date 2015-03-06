//Write a method that reverses the digits of given decimal number.

using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());
        number = ReversingNumber(number);
        Console.WriteLine("Reversed number is {0}", number);
    }
    static decimal ReversingNumber(decimal number)
    {
        string strNum = Convert.ToString(number);
        string strReversed = string.Empty;
        for (int i = 0; i < strNum.Length; i++)
        {
            strReversed += strNum[strNum.Length - i - 1];
        }
        decimal decimalNum = decimal.Parse(strReversed);
        return decimalNum;
    }
}
