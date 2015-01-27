/*  Write a program that reads two positive integer numbers and prints how many
    numbers p exist between them such that the reminder of the division by 5 is 0. */

using System;
class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter positive number for start of interval:");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter positive number for end of interval:");
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        if (start <= end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i%5 == 0)
                {
                    counter++;
                }
            }
        }
        else
        {
            for (int i = end; i <= start; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine("There are {0} numbers in this interval [{1} , {2}].",
           counter, start, end);
        Main();
    }
}

