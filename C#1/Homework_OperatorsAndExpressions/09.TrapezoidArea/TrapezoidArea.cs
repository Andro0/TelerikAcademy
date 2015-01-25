//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter side a of trapezoid:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side b of trapezoid:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter height a of trapezoid:");
        double height = double.Parse(Console.ReadLine());

        double trapezoidArea = (sideA + sideB) * height / 2;
        Console.WriteLine("The area of the trapezoid with sides a={0}, b={1} and height={2} is:{3}",
                             sideA, sideB, height, trapezoidArea);

    }
}