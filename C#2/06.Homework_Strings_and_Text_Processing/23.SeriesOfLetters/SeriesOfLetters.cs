/*  Write a program that reads a string from the console and replaces all series of
    consecutive identical letters with a single one.
 */

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter consecutive letters:");
        string text = Console.ReadLine();//LLLLLLLLLLLlllllllllllllllLLLLLLLeeeeeeeeeeeNNNNNNNNNNooooVVVVVVVVVVVVVVVooooooooooooo


        StringBuilder unique = new StringBuilder();
        char letter = text[0];
        unique.Append(text[0]);
        for (int i = 0; i < text.Length; i++)
        {
            if (letter == text[i])
            {
                continue;
            }
            else
            {
                unique.Append(text[i]);
                letter = text[i];
            }
        }
        unique.ToString();
        Console.WriteLine("Result string is:{0}", unique);

    }
}