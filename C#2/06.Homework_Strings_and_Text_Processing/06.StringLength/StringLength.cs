/*  Write a program that reads from the console a string of maximum 20 characters.
    If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
 */

using System;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter text with maximum 20 characters.\n(If text is bigger than 20 characters text will be trimed):");
        string text = Console.ReadLine();
        if (text.Length > 20)
        {
            text = text.Remove(20);
        }
        else
        {
            string symbol = new string('*', 20 - text.Length);
            text += symbol;
        }
        Console.WriteLine(text);
    }
}
