/*  Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.*/

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter array elements separated by space:");
        string numbers = Console.ReadLine();
        var intArr = numbers.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        Console.Write("Sorted array in descending order is:");
        SortArray(intArr);

    }
    static int MaxElement(int[] array, int startPosition)
    {
        int maxElement = array[startPosition];
        for (int i = startPosition; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }
        return maxElement;
    }

    static void SortArray(int[] array)
    {
        int startPosition = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(MaxElement(array, startPosition) + " ");
            for (int j = 0; j < array.Length; j++)
            {
                if (MaxElement(array, startPosition) == array[j])
                {
                    array[j] = int.MinValue;
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}