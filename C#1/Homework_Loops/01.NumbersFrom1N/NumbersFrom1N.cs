/*  Write a program that enters from the console a positive integer n and prints all the numbers
    from 1 to n, on a single line, separated by a space.*/

using System;
class NumbersFrom1N
{
    static void Main()
    {
        Console.Write("Enter positive integer n:");
        int num=int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.Write("{0} ",i); 
        }
        Console.ReadLine();
    }
}