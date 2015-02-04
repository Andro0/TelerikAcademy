/*  Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
    the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.*/

using System;
class MinMaxSumAvgOfNNums
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to enter:");
        int num = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        long sum = 0;
        double avg;

        for (int i = 1; i <= num; i++)
        {
            Console.Write("Enter number {0} of {1}:--->", i, num);
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number >= max)
            {
                max = number;
            }
            if (number <= min)
            {
                min = number;
            }
        }
        Console.WriteLine("min={0}",min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:f2}", ((double)sum/(double)num));
    }
}