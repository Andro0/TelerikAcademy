/*  Write a program that reads the coefficients a, b and c of a quadratic equation
    ax2 + bx + c = 0 and solves it (prints its real roots). */

using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a:");
        double coefA = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b:");
        double coefB = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c:");
        double coefC = double.Parse(Console.ReadLine());

        double determinant = coefB * coefB - 4 * coefA * coefC;

        if (determinant < 0)
        {
            Console.WriteLine("The equation do NOT has real root");
        }
        else if (determinant == 0)
        {
            Console.WriteLine("The equation has one double real root x1=x2={0}",
                -coefB / (2 * coefA));
        }
        else if (determinant > 0)
        {
            double x1 = (-coefB - Math.Sqrt((coefB * coefB - 4 * coefA * coefC))) / (2 * coefA);
            double x2 = (-coefB + Math.Sqrt((coefB * coefB - 4 * coefA * coefC))) / (2 * coefA);
            Console.WriteLine("The equation has two real roots x1={0}; x2={1}", x1, x2);
        }
    }
}
