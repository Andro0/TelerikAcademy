/*  Write a program, that reads from the console an array of N integers and an integer K, sorts the array
    and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array of integers on a single line separated by space:");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write("Enter value K to perform binary search K=");
        int kValue = int.Parse(Console.ReadLine());

        Array.Sort(numbers);
        int result = Array.BinarySearch(numbers, kValue);
        int key = kValue;

        if (result == -1)
        {
            Console.WriteLine("No element value meets the conditions to be <= {0} exists in the array.", kValue);
        }
        else if (result >= 0)
        {
            Console.WriteLine("The largest element value in the array smaller than {0} is {1}", kValue, numbers[result]);
        }
        else
        {
            while (result < 0)
            {
                key--;
                result = Array.BinarySearch(numbers, key);
            }
            Console.WriteLine("The largest element value  <= {0} in the array is {1}", kValue, numbers[result]);
        }
    }
}