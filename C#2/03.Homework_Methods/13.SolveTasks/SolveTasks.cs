/*  Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("1.Reverse the digits of a number.");
        Console.WriteLine("2.Calculate the average of a sequence of integers.");
        Console.WriteLine("3.Solve a linear equation a * x + b = 0.");
        Console.Write("\nPlease make a choice, enter 1, 2 or 3:");
        int choice = int.Parse(Console.ReadLine());

         switch (choice)
        {
            case 1:
                Console.Write("Enter a number:");
                ReverseDigits(long.Parse(Console.ReadLine()));
                break;

            case 2:
                Console.Write("Enter a sequence of numbers on a single line separated by space:");
                try
                {
                    Average(Console.ReadLine().Split(' ').Select(long.Parse).ToArray());
                }
                catch
                {
                    Console.Write("NOT_VALID!");
                }
                break;

            case 3:
                Console.Write("Enter coefficients a and b on a single line separated by space,\nwhere a*x+b=0:");
                LinearEquation(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }


    static void ReverseDigits(long number)
    {
        if (number < 0)
        {
            Console.WriteLine("NOT_VALID!");
        }
        else
        {
            while (number % 10 == 0)
            {
                number /= 10;
            }
            Console.Write("Reversed number = ");
            while (number != 0)
            {
                Console.Write(number % 10);
                number /= 10;
            }
            Console.WriteLine();
        }
    }

    static void Average(long[] numbers)
    {
        long avg = 0;
        for (int n = 0; n < numbers.Length; n++)
        {
            avg += numbers[n];
        }
        avg /= numbers.Length;
        Console.WriteLine("AVG = {0}", avg);
    }

    static void LinearEquation(int[] parameters)
    {
        if (parameters[0] == 0)
        {
            Console.WriteLine("NOT_VALID!");
        }
        else
        {
            decimal x = -parameters[1] / parameters[0];
            Console.WriteLine("x = {0}", x);
        }
    }
}
