/*  Write a method that checks if the element at given position in given array of integers is 
    larger than its two neighbours (when such exist).*/

using System;
using System.Linq;
class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter array elements separated by space:");
        string numbers = Console.ReadLine();
        Console.Write("Enter position to check if value is larger than its neighbours:");
        int index = int.Parse(Console.ReadLine());
        var intArr = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        LargerThanNeighboors(index, intArr);
    }
    static void LargerThanNeighboors(int index, int[] array)
    {
        if (index > 0 && index < array.Length - 1)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                Console.WriteLine("Is element with index {0} is larger than neighboors elements?--->{1}", index, true);
            }
            else
            {
                Console.WriteLine("Is element with index {0} is larger than neighboors elements?--->{1}", index, false);
            }
        }
        else
        {
            Console.WriteLine("There is not two neighboors element between index {0}", index);
        }
    }
}
