//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static Random rand = new Random();
    static void Main()
    {
        Console.WriteLine("Here are ten random numbers between 100 and 200:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(100, 201));
        }

    }
}