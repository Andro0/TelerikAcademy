/*  Write a program that reads a string from the console and lists all different words
    in the string along with information how many times each word is found.
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine().ToLower();

        Dictionary<string, int> words = new Dictionary<string, int>();
        CountWords(text, words);

        if (words.Count == 0)
        {
            Console.WriteLine("No words to count!");
        }
        else
        {
            foreach (var word in words)
            {
                Console.WriteLine("{0} - {1}", word.Value, word.Key);
            }
        }

    }
    private static void CountWords(string text, Dictionary<string, int> words)
    {
        foreach (var match in Regex.Matches(text, @"\w+"))
        {
            if (!words.ContainsKey(match.ToString()))
            {
                words.Add(match.ToString(), 1);
            }
            else
            {
                words[match.ToString()] += 1;
            }
        }
    }
}
