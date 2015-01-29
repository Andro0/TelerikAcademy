/*  Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.*/

using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Enter number c:");
        double numC = double.Parse(Console.ReadLine());
        
        if (numA > 0)
        {
            if (numB > 0)
            {
                if (numC > 0)
                {
                    Console.WriteLine("+");
                }
                else if (numC < 0)
                {
                    Console.WriteLine("-");
                }
                else if (numC == 0)
                {
                    Console.WriteLine("0");
                }
            }
            else if (numB < 0)
            {
                if (numC > 0)
                {
                    Console.WriteLine("-");
                }
                else if (numC < 0)
                {
                    Console.WriteLine("+");
                }
                else if (numC == 0)
                {
                    Console.WriteLine("0");
                }
            }
            else if (numB == 0)
            {
                Console.WriteLine("0");
            }
        }
        else if (numA < 0)
        {
            if (numB > 0)
            {
                if (numC > 0)
                {
                    Console.WriteLine("-");
                }
                else if (numC < 0)
                {
                    Console.WriteLine("+");
                }
                else if (numC == 0)
                {
                    Console.WriteLine("0");
                }
            }
            else if (numB < 0)
            {
                if (numC > 0)
                {
                    Console.WriteLine("+");
                }
                else if (numC < 0)
                {
                    Console.WriteLine("-");
                }
                else if (numC == 0)
                {
                    Console.WriteLine("0");
                }
            }
            else if (numB == 0)
            {
                Console.WriteLine("0");
            }
        }
        else if (numA == 0)
        {
            Console.WriteLine("0");
        }

    }
}
