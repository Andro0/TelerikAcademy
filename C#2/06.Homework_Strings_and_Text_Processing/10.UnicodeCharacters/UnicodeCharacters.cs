/*  Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
*/

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("\\u{0:x4}", (ushort)text[i]);
        }
        Console.WriteLine();

    }
}
