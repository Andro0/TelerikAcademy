/*  Write a method that returns the index of the first element in array that is larger than its 
    neighbours, or -1, if there’s no such element.
    Use the method from the previous exercise.*/

using System;
using System.Linq;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter array elements separated by space:");
        string numbers = Console.ReadLine();
        var intArr = numbers.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToArray();

        int result = CheckAllNeighbors(intArr);
        if (result != -1) Console.WriteLine("First element larger than its neighbours is at position--> {0}", result);
        else Console.WriteLine("No such element");
    }
    static int CheckAllNeighbors(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (LargerThanNeighboors(i, array)) return i;
        }
        return -1;
    }

    static bool LargerThanNeighboors(int index, int[] array)
    {
        if (array[index] > array[index - 1] && array[index] > array[index + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
