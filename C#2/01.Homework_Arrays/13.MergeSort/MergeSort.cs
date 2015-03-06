//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MergeSort
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
        intArr = MergeSortArray(intArr);
        PrintArray(intArr);

    }
    public static void PrintArray(int[] numbersArray)
    {
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write("{0}", numbersArray[i]);
            if (i < numbersArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    public static int[] MergeSortArray(int[] arrayToSort)
    {
        return (MergeSortList(arrayToSort.ToList<int>())).ToArray<int>();
    }

    public static List<int> MergeSortList(List<int> ListToSort)
    {
        if (ListToSort.Count <= 1)
        {
            return ListToSort;
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();
        List<int> result = new List<int>();

        int middle = ListToSort.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(ListToSort[i]);
        }

        for (int i = middle; i < ListToSort.Count; i++)
        {
            right.Add(ListToSort[i]);
        }
        left = MergeSortList(left);
        right = MergeSortList(right);
        result = Merge(left, right);
        return result;
    }

    public static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else if (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        return result;

    }
}
