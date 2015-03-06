//Write a program that finds the most frequent number in an array.

using System;
class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter array elements separated by space:");
        string input = Console.ReadLine();
        string[] transformedInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] intArr = new int[transformedInput.Length];
        for (int i = 0; i < transformedInput.Length; i++)
        {
            intArr[i] = int.Parse(transformedInput[i]);
        }

        int tempCounter = 1;
        int counter = 0;
        int index = 0;

        for (int i = 0; i < intArr.Length; i++)
        {
            for (int j = 1; j < intArr.Length; j++)
            {
                if (intArr[i] == intArr[j])
                {
                    tempCounter++;
                }
            }
            if (tempCounter > counter)
            {
                counter = tempCounter;
                index = i;
            }
            tempCounter = 0;

        }
        Console.WriteLine("Integer {0} is found {1} times.", intArr[index], counter);

    }
}
