/*  Write a program that enters 3 real numbers and prints them sorted in descending order.
    Use nested if statements.*/

using System;
class Sort3NumbersNestedIf
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Enter number c:");
        double numC = double.Parse(Console.ReadLine());

        if (numA > numB)
        {
            if (numA > numC)
            {
                Console.WriteLine("The sorted numbers are: {0} {1} {2}", numA, numC, numB);
            }
            else
            {
                Console.WriteLine("The sorted numbers are: {0} {1} {2}", numC, numA, numB);
            }
        }
        else
        {
            if (numB > numC)
            {
                Console.WriteLine("The sorted numbers are: {0} {1} {2}", numB, numC, numA);
            }
            else
            {
                Console.WriteLine("The sorted numbers are: {0} {1} {2}", numC, numB, numA);
            }
        }

    }
}
