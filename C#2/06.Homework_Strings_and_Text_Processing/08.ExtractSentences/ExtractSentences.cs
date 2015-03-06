//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();
        //Variant where we have real number and show one sentence instead of two
        //string text="Live in Bulgaria where beer is 2.50 leva in Sofia."
        Console.Write("Enter word:");
        string word = Console.ReadLine();
        string[] matches = SentencesContainWord(text, word);
        if (matches.Length == 0)
        {
            Console.WriteLine("No matches found!");
        }
        else
        {
            foreach (var sentence in matches)
            {
                Console.WriteLine("-->" + sentence);
            }
        }
    }

    private static string[] SentencesContainWord(string text, string word)
    {
        int dotIndex = 0;
        StringBuilder result = new StringBuilder();
        var sentences = new List<string>();
        var matches = new List<string>();
        char[] separators = { ' ', ',', '.' };
        while (dotIndex < text.Length - 1)
        {
            dotIndex = text.IndexOf('.', dotIndex + 1);
            if (dotIndex + 1 != text.Length)
            {
                if ((char)text[dotIndex + 1] > '0' && (char)text[dotIndex + 1] < '9')
                {
                    dotIndex = text.IndexOf('.', dotIndex + 1);
                    string sentence = text.Substring(0, dotIndex + 1);
                    sentences.Add(sentence);
                    text = text.Remove(0, dotIndex + 1);
                    dotIndex = 0;
                }
                else
                {
                    string sentence = text.Substring(0, dotIndex + 1);
                    sentences.Add(sentence);
                    text = text.Remove(0, dotIndex + 1);
                    dotIndex = 0;
                }
            }
            else
            {
                string sentence = text.Substring(0, dotIndex + 1);
                sentences.Add(sentence);
                text = text.Remove(0, dotIndex + 1);
                dotIndex = 0;
            }
        }
        foreach (var sentence in sentences)
        {
            if (Regex.IsMatch(sentence.ToLower(), String.Format
                ("{0}{1}{2}", "(^|[.;,:!? -])", word.ToLower(), "([.;,:!? -]|$)"),
                RegexOptions.IgnoreCase))
            {
                matches.Add(sentence.Trim());
            }
        }
        return matches.ToArray();

    }


}
