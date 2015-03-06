/*  Write methods that calculate the surface of a triangle by given:
    Side and an altitude to it;
    Three sides;
    Two sides and an angle between them;
    Use System.Math.*/

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("1. Surface of a triangle by -->Side and an altitude to it");
        Console.WriteLine("2. Surface of a triangle by -->Three sides");
        Console.WriteLine("1. Surface of a triangle by -->Two sides and an angle between them");

        Console.Write("Choose 1, 2 or 3 -->");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("Enter side:");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude to it:");
            double alt = double.Parse(Console.ReadLine());
            SideAndAltitude(side, alt);
        }
        else if (choice == 2)
        {
            Console.Write("Enter sideA:");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter sideB:");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Enter sideC:");
            double sideC = double.Parse(Console.ReadLine());
            ThreeSides(sideA, sideB, sideC);
        }
        else if (choice == 3)
        {
            Console.Write("Enter sideA:");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter sideB:");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Enter angle between them in degrees [1...179]:");
            double angle = double.Parse(Console.ReadLine());
            TwoSidesAndAngle(sideA, sideB, angle);
        }

    }

    static void SideAndAltitude(double side, double altitude)
    {
        double area = side * altitude / 2;
        Console.WriteLine("Surface of the triangle is {0}", area);
    }

    static void ThreeSides(double sideA, double sideB, double sideC)
    {
        double perimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        Console.WriteLine("Surface of the triangle is {0}", area);
    }

    static void TwoSidesAndAngle(double sideA, double sideB, double angleDegrees)
    {
        double radian = angleDegrees * Math.PI / 180;
        double area = sideA * sideB * Math.Sin(radian) / 2;
        Console.WriteLine("Surface of the triangle is {0}", area);
    }
}
