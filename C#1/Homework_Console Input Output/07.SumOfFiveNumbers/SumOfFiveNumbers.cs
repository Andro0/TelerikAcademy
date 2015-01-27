/*  Write a program that enters 5 numbers (given in a single line, separated by a space),
    calculates and prints their sum. */

using System;
class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers separated by a space:");
        string fiveNums = Console.ReadLine();
        double sum = 0;
        string singleNum = null;
        int strLenght = fiveNums.Length - 1;

        for (int i = 0; i <= strLenght; i++)
        {
            if (fiveNums[i] != ' ')
            {
                singleNum += fiveNums[i];
            }
            else
            {
                sum += Convert.ToDouble(singleNum);
                singleNum = null;
            }
        }
        Console.WriteLine(sum + Convert.ToDouble(singleNum));

    }
}
