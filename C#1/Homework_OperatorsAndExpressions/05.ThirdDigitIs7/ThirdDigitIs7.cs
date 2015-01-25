//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter integer to check if its third digit from right is 7:");
        int intNum = int.Parse(Console.ReadLine());

        Console.WriteLine(intNum %= 1000);
        Console.WriteLine(intNum /= 100);
        Console.WriteLine(((intNum == 7) ? true : false));

    }

}


