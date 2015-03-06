//Write a program that finds the maximal increasing sequence in an array.

using System;
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter sequence of elements:");
        string input = Console.ReadLine();
        char[] delimeters = { ' ', ',' };
        string[] seqArray = input.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

        int numOfIncrElement = 1;
        int maxNumOfElements = 1;
        int maxIncrElementIndex = 0;

        for (int i = 1; i < seqArray.Length; i++)
        {
            if (int.Parse(seqArray[i]) > int.Parse(seqArray[i - 1]))
            {
                numOfIncrElement++;
            }
            else
            {
                numOfIncrElement = 1;
            }
            if (maxNumOfElements <= numOfIncrElement)
            {
                maxNumOfElements = numOfIncrElement;
                maxIncrElementIndex = i;
            }
        }
        if (maxNumOfElements > 1)
        {
            Console.WriteLine("Max increasing sequence is: {0}", maxNumOfElements);
            for (int i = maxIncrElementIndex + 1 - maxNumOfElements; i <= maxIncrElementIndex; i++)
            {
                Console.Write("{0}", int.Parse(seqArray[i]));
                if (i < maxIncrElementIndex)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is not increasing sequence in the array");
        }






    }
}
