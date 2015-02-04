//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
class RandomizeNumbers1N
{
    static void Main()
    {
        Console.Write("Enter number n:");
        int n = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int[] randomArr = new int[n];
        randomArr[0] = rand.Next(1, n + 1);

        for (int i = 1; i < n; i++)
        {
            randomArr[i] = rand.Next(1, n + 1);
            for (int j = 0; j < n; j++)
            {
                if (randomArr[i] == randomArr[j] && i != j)
                {
                    randomArr[i] = rand.Next(1, n + 1);
                    i--;

                }
            }

        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", randomArr[i]);
        }

    }
}
