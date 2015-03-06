//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class CompareCharArrays
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter First char array(word):");
        string firstWord = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Enter First char array(word):");
        string secondWord = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;
        char[] arr1 = firstWord.ToCharArray();
        char[] arr2 = secondWord.ToCharArray();

        int minLenght = Math.Min(arr1.Length, arr2.Length);
        bool isEqual = false;
        for (int i = 0; i < minLenght; i++)
        {
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine("Lexicographically first is: {0}", string.Join("", arr1));
                break;
            }
            else if (arr1[i] > arr2[i])
            {
                Console.WriteLine("Lexicographically first is: {0}", string.Join("", arr2));
                break;
            }
            else
            {
                isEqual = true;
            }
        }

        if (isEqual)
        {
            if (arr1.Length < arr2.Length)
            {
                Console.WriteLine("Lexicographically first is: {0}", string.Join("", arr1));
            }
            else if (arr1.Length > arr2.Length)
            {
                Console.WriteLine("Lexicographically first is: {0}", string.Join("", arr2));
            }
            else
            {
                Console.WriteLine("Both arrays are equal");
            }
        }
    }
}
