//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words separated by space:");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> wordsList = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            if (!wordsList.Contains(words[i]))
            {
                wordsList.Add(words[i]);
            }
        }
        wordsList.Sort();
        Console.WriteLine("\nWords in alphabetical order");
        Console.WriteLine(new string('-',30));
        foreach (var word in wordsList)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine();

    }
}