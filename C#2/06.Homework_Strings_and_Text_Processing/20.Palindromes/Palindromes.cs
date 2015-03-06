//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Linq;

class Palindromes
{
    static char[] delimiters = new char[] { ' ', '.', ',', '!', '?', '\"' };
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length < 2)
            {
                continue;
            }
            if (IsPalindrome(words[i]))
            {
                Console.WriteLine(words[i]);
            }
        }

    }
    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i].ToString().ToLower() == word[word.Length - 1 - i].ToString().ToLower())
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

}
