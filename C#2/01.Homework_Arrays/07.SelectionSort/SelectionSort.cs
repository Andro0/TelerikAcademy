/*  Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
    smallest from the rest, move it at the second position, etc. */

using System;
class SelectionSort
{
    static void Main()
    {
        Console.Write("Write integer array (separate elements by space):");
        string input = Console.ReadLine();
        char[] delimeters = new char[] { ' ', ',' };
        string[] inputArr = input.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
        int length = inputArr.Length;
        int[] intArr = new int[length];

        for (int i = 0; i < length; i++)
        {
            intArr[i] = int.Parse(inputArr[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < length; j++)
            {
                if (intArr[j] < intArr[min])
                {
                    min = j;
                }

            }
            if (min != i)
            {
                int temp = intArr[min];
                intArr[min] = intArr[i];
                intArr[i] = temp;
            }
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0}", intArr[i]);
            if (i < length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

    }
}
