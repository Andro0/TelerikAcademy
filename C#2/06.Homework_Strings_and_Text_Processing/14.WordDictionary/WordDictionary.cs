/*  A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.
 */

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter number of words in dictionary:");
        int n = int.Parse(Console.ReadLine());
        string[] dictionary = new string[n];
        var wordDictionary = new Dictionary<string, string>();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter word {0}:", i);
            string dictWord = Console.ReadLine();
            Console.Write("Enter description for word {0}:", i);
            string description = Console.ReadLine();
            wordDictionary.Add(dictWord, description);
        }
        Console.WriteLine();
        Console.Write("Enter word to search in dictionary:");
        string word = Console.ReadLine();

        foreach (var item in wordDictionary)
        {
            if (item.Key == word)
            {
                Console.WriteLine("The word {0} means -->{1}", item.Key, item.Value);
            }
        }

    }
}
