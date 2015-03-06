//Write a program that finds the sequence of maximal sum in given array.

using System;
class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter array elements separated by space:");
        string input = Console.ReadLine();
        string[] transformedInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Enter how many elements to check for max sequence sum (1<=K<=N) K=");
        int k = int.Parse(Console.ReadLine());
        if (transformedInput.Length == 0)
        {
            Console.WriteLine("Array do not have elements!!!");
            return;
        }
        if (k == 0)
        {
            Console.WriteLine("K=0! No such max sequence sum!!!");
            return;
        }

        int[] intArr = new int[transformedInput.Length];
        for (int i = 0; i < transformedInput.Length; i++)
        {
            intArr[i] = int.Parse(transformedInput[i]);
        }

        int currentSum = 0;
        int maxIndex = 0;
        int maxSum = 0;
        int maxArrayElementsCount = 1;

        for (int i = 0; i <= intArr.Length - k; i++)
        {
            int j = i;
            for (; j < i + k; j++)
            {
                currentSum += intArr[j];
            }
            if (currentSum > maxSum)
            {
                maxIndex = i;
                maxSum = currentSum;
                maxArrayElementsCount = j - i;
            }
            currentSum = 0;
        }

        for (int i = maxIndex; i < maxIndex + maxArrayElementsCount; i++)
        {
            if (i != maxIndex + maxArrayElementsCount - 1)
            {
                Console.Write(intArr[i] + " ");
            }
            else
            {
                Console.Write(intArr[i]);
            }
        }
        Console.WriteLine();
    }
}
