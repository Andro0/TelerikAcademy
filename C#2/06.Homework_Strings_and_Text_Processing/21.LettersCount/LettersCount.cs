/*  Write a program that reads a string from the console and prints all different letters 
    in the string along with information how many times each letter is found.
 */

using System;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();//Welll, heereeee is some texxxxxxxt, paaaalssss!
        int[] letters = new int[256];

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < 256; j++)
            {
                if ((int)text[i] == j)
                {
                    letters[j]++;
                }
            }
        }

        for (int i = 0; i < 256; i++)
        {
            if (letters[i] != 0)
            {
                Console.WriteLine("{0} - {1}", (char)i, letters[i]);
            }
        }

    }
}
