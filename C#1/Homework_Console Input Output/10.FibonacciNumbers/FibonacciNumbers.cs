/*  Write a program that reads a number n and prints on the console the first n members of the
    Fibonacci sequence (at a single line, separated by comma and space - ,) :
    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….  */

using System;
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number n:");
        ulong num = ulong.Parse(Console.ReadLine());
        ulong current = 1;
        ulong previous = 0;
        Console.Write("{0}, ", previous);
        for (ulong i = 1; i < num; i++)
        {
            Console.Write("{0}, ", current);
            current = current + previous;
            previous = current - previous;
        }
    }
}

