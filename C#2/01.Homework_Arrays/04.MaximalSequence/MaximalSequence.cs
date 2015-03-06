//Write a program that finds the maximal sequence of equal elements in an array.

using System;
class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter sequence of elements:");
        string input = Console.ReadLine();
        char[] delimeters = { ' ', ',' };
        string[] seqArray = input.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

        int countSameElement = 1;
        int maxSameElement = 0;
        int sameElement = int.Parse(seqArray[0]);

        for (int i = 1; i < seqArray.Length; i++)
        {
            int current = int.Parse(seqArray[i]);
            int previous = int.Parse(seqArray[i - 1]);

            if (current == previous)
            {
                countSameElement++;
            }
            else
            {
                countSameElement = 1;
            }
            if (maxSameElement <= countSameElement)
            {
                maxSameElement = countSameElement;
                sameElement = int.Parse(seqArray[i - 1]);
            }
        }
        Console.WriteLine("Max sequence is: {0}", maxSameElement);
        for (int i = 0; i < maxSameElement; i++)
        {
            Console.Write("{0}", sameElement);
            if (i < maxSameElement - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }



}
