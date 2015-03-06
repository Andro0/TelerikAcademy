//Write a program that reads a string, reverses it and prints the result at the console.

using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string to be reversed:");
        string str = Console.ReadLine();
        char[] reversedStr = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            reversedStr[i] = str[str.Length - i - 1];
        }
        string reversed = string.Join("", reversedStr);
        Console.WriteLine(reversed);
    }
}
