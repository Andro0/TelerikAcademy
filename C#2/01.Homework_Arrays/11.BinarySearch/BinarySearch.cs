/*  Write a program that finds the index of given element in a sorted array of integers by using
    the Binary search algorithm. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array elements on a single line separated by space:");
        string input = Console.ReadLine();
        string[] transformedInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Enter element to check what index it has: ");
        int element = int.Parse(Console.ReadLine());

        int[] intArr = new int[transformedInput.Length];
        for (int i = 0; i < transformedInput.Length; i++)
        {
            intArr[i] = int.Parse(transformedInput[i]);
        }
        Array.Sort(intArr);
        BinarySearchIndex(element, intArr);
    }

    static void BinarySearchIndex(int numberToFind, int[] array)
    {
        int startIndex = 0;
        int endIndex = array.Length - 1;
        int currentIndex = 0;

        currentIndex = (startIndex + endIndex) / 2;
        do
        {

            if (array[currentIndex] == numberToFind)
            {
                Console.WriteLine("The index of {0} is {1}", numberToFind, currentIndex);
                return;
            }
            else if (array[currentIndex] > numberToFind)
            {
                endIndex = currentIndex;
                currentIndex = (startIndex + endIndex - 1) / 2;
            }
            else
            {
                startIndex = currentIndex;
                currentIndex = (startIndex + endIndex + 1) / 2;
            }

        } while (startIndex != endIndex);

        Console.WriteLine("There are no such element in the array.");
    }


}