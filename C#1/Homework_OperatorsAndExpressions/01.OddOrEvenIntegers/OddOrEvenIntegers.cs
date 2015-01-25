//Write an expression that checks if given integer is odd or even.
using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter integer to see if it is Odd:");
        int intNum = int.Parse(Console.ReadLine());

        Console.WriteLine((intNum % 2) == 0 ? false : true);

    }
}

