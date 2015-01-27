/*  Write a program that enters a number n and after that enters more n numbers
    and calculates and prints their sum. */

using System;
class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number n:");
        int num = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= num; i++)
        {
            Console.Write("Enter number {0} of {1}:-->", i, num);
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of all {0} number/s is: {1}", num, sum);

    }
}

