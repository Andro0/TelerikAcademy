//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        double numOne = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double numTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double numThree = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three numbers is: {0}", numOne + numTwo + numThree);

    }
}

