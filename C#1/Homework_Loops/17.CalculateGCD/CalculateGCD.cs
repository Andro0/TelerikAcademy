/*  Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).*/

using System;
class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter integer a:");
        int numA = int.Parse(Console.ReadLine());

        Console.Write("Enter integer b:");
        int numB = int.Parse(Console.ReadLine());

        int GCD = 0;
        int n = 0;

        while (numA != 0 && numB != 0)
        {
            if (numA > numB)
            {
                n = numB;
                numB = numA;
                numA = n;
            }
            while (numB != 0)
            {
                GCD = numA % numB;
                numA = numB;
                if (GCD == 0)
                {
                    GCD = numB;
                    numB = 0;
                }
                else
                {
                    numB = GCD;
                }
            }
        }
        Console.WriteLine(GCD);
        
    }
}
