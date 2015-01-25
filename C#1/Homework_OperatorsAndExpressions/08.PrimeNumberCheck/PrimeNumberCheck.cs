/*  Write an expression that checks if given positive integer number n (n <= 100) is prime
    (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive */

using System;
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter positive integer smaller or equal to 100 to check if it is prime:");
        int intNum = int.Parse(Console.ReadLine());
        int lastCount = (int)Math.Sqrt(intNum);
        bool isPrime = true;

        if (intNum >= 0)
        {
            for (int i = 2; i <= lastCount; i++)
            {
                if (intNum % i == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine("Is Prime? {0}", isPrime);
        }
        else
        {
            Console.WriteLine("Your number is negative");
        }

    }
}

