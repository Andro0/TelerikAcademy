/*  Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.*/

using System;
using System.Linq;
class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter array elements on a single line separated by space:");
        string numbers = Console.ReadLine();
        Console.Write("Enter number to check how many times it appears in the array N=");
        int numToCheck = int.Parse(Console.ReadLine());
        var intArray = numbers.Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        NumAppearanceInArray(numToCheck, intArray);

    }
    static void NumAppearanceInArray(int searchKey, int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (searchKey == array[i])
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Number {0} is NOT in the array", searchKey);
        }
        else
        {
            Console.WriteLine("Number {0} appears {1} time/s in the array", searchKey, count);
        }
    }
}
