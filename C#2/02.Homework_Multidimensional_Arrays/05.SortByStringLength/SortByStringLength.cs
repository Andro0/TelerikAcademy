/*  You are given an array of strings. Write a method that sorts the array by the length of 
    its elements (the number of characters composing them).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter array of strings on a single line separated by space:");
        string[] inputStr = Console.ReadLine().Split(' ');

        string[] sortedStrArray = SortStrArrayByLength(inputStr);
        Console.WriteLine("Sorted string array is:");
        Console.WriteLine(string.Join("\n", sortedStrArray));

    }

    private static string[] SortStrArrayByLength(string[] inputStr)
    {
        int[] elementLengths = new int[inputStr.Length];
        for (int i = 0; i < inputStr.Length; i++)
        {
            elementLengths[i] = inputStr[i].Length;
        }

        Array.Sort(elementLengths);

        string[] sortedStrArray = new string[inputStr.Length];
        for (int i = 0; i < inputStr.Length; i++)
        {
            for (int j = 0; j < inputStr.Length; j++)
            {

                if (elementLengths[i] == inputStr[j].Length)
                {
                    sortedStrArray[i] = inputStr[j];
                    inputStr[j] = "";
                    break;
                }

            }
        }
        return sortedStrArray;
    }
}