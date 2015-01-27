/*  Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned. */

using System;
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter number a between 0 and 500 including:");
        int numA = int.Parse(Console.ReadLine());
        Console.Write("Enter real number b:");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Enter real number c:");
        double numC = double.Parse(Console.ReadLine());

        if (numA >= 0 && numA <= 500)
        {
            Console.Write(Convert.ToString(numA, 16).PadRight(10) + "|");
            Console.Write(Convert.ToString(numA, 2).PadLeft(10, '0') + "|");
            Console.Write("{0:f2}".PadLeft(10) + "|", numB);
            Console.WriteLine("{0:f3}".PadRight(10) + "|", numC);

        }
        else
        {
            Console.WriteLine("Number a should be between 0 and 500 including");
        }

    }
}
