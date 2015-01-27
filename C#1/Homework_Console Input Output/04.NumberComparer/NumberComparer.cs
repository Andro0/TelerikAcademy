/*  Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements. */

using System;
class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double numB = double.Parse(Console.ReadLine());

        double isBigger = Math.Max(numA, numB);
        Console.WriteLine("The greater from numbers {0} and {1} is:{2}",
            numA, numB, isBigger);
        
    }
}
