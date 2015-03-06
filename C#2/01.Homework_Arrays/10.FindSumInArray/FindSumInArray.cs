//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter what sum to check in the array: S=");
        int sum = int.Parse(Console.ReadLine());

        Console.Write("Enter array elements separated by space:");
        string input = Console.ReadLine();

        string[] transformedInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] intArr = new int[transformedInput.Length];
        for (int i = 0; i < transformedInput.Length; i++)
        {
            intArr[i] = int.Parse(transformedInput[i]);
        }

        FindSequenceOfGivenSum(sum, intArr);
        Console.Write(" equal to sum S={0}", sum);
        Console.WriteLine();
    }
    static void PrintArray(int startIndex, int endIndex, int[] array)
    {
        Console.Write("Sequence of elements { ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0} ", array[i]);
            if (i < endIndex)
            {
                Console.Write(", ");
            }
        }
        Console.Write("}");
    }

    private static void FindSequenceOfGivenSum(int sum, int[] numbersArray)
    {
        long currentSum = 0;
        for (int currentEndIndex = 0; currentEndIndex < numbersArray.Length; currentEndIndex++)
        {
            currentSum = 0;
            for (int currentSumIndex = currentEndIndex; currentSumIndex >= 0; currentSumIndex--)
            {
                currentSum += numbersArray[currentSumIndex];
                if (currentSum == sum)
                {
                    PrintArray(currentSumIndex, currentEndIndex, numbersArray);
                    return;
                }
            }
        }
        Console.Write("There is no sequence of elements");




    }
}