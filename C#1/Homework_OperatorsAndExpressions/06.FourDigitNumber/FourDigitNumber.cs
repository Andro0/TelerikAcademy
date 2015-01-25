/*  Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0. */

using System;
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter four-digit numbe:");
        ushort fourDigNum = ushort.Parse(Console.ReadLine());

        byte d = (byte)(fourDigNum % 10);
        fourDigNum /= 10;
        byte c = (byte)(fourDigNum % 10);
        fourDigNum /= 10;
        byte b = (byte)(fourDigNum % 10);
        fourDigNum /= 10;
        byte a = (byte)(fourDigNum % 10);
        Console.WriteLine("The sum of the digits is:{0}",a+b+c+d);
        Console.WriteLine("Reversed:{0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("Last digit in front:{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged:{0}{1}{2}{3}", a, c, b, d);
        
    }
}

