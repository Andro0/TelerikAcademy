/*  We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.
*/

using System;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();
        Console.Write("Enter forbidden words:");
        string words = Console.ReadLine();

        string[] wordsToRemove = Regex.Split(words, @"\W+");

        for (int i = 0; i < wordsToRemove.Length; i++)
        {
            text = Regex.Replace(text, string.Format(@"\b{0}\b", wordsToRemove[i]), new string('*', wordsToRemove[i].Length));
        }

        Console.WriteLine("Text without forbidden words is--->{0}", text);

    }
}
