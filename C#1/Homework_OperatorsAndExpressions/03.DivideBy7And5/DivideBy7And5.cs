/* Write a Boolean expression that checks for given integer if it can be divided
   (without remainder) by 7 and 5 at the same time. */

using System;
class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter integer to see if it divides by 5 and 7 at the same time:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(((num % 5) == 0) && ((num % 7) == 0) ? true : false);

    }
}

