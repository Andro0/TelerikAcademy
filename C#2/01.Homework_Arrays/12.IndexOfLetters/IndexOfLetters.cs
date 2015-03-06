/*  Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main()
    {
        Console.Write("Enter a word:");
        string word = Console.ReadLine();

        string[] alphabetArray = new string[26];

        for (int i = 0; i < alphabetArray.Length; i++)
        {
            alphabetArray[i] = Convert.ToString(Convert.ToChar(i + 65));
        }
        for (int i = 0; i < word.Length; i++)
        {
            PrintLetterIndex(alphabetArray, word, i);
        }

    }
    static void PrintLetterIndex(string[] alphabetArray, string word, int indexToStart)
    {
        word = word.ToUpper();
        for (int i = 0; i < alphabetArray.Length; i++)
        {
            if (Convert.ToString(word[indexToStart]) == alphabetArray[i])
            {
                Console.WriteLine("{0}-->{1}", word[indexToStart], i);
                return;
            }
        }
        Console.WriteLine("Error - Not a letter!");
    }

}