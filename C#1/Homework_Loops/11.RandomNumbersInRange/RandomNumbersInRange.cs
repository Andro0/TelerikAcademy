/*  Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers
    in the range [min...max]. */

using System;
    class RandomNumbersInRange
    {
        static void Main()
        {
            Console.Write("Enter how many numbers to be genaratet in range [min...max] n=");
            int n= int.Parse(Console.ReadLine());
            Console.Write("Enter min of range min=");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max of range max=");
            int max = int.Parse(Console.ReadLine());

            Random rand=new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ",rand.Next(min,max+1)); 
            }
            Console.WriteLine();
        }

    }
