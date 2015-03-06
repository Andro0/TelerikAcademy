//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuickSort
{
    static void Main()
    {
        Console.Write("Enter array elements on a single line separated by space:");
        string input = Console.ReadLine();
        string[] transformedInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] intArr = new int[transformedInput.Length];
        for (int i = 0; i < transformedInput.Length; i++)
        {
            intArr[i] = int.Parse(transformedInput[i]);
        }
        int arrLength = intArr.Length;
        Quicksort(intArr, 0, arrLength - 1);
        PrintArray(intArr);

    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}", array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }

    }

}