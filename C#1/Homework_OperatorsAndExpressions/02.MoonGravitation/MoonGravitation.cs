/*  The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */

using System;
class MoonGravitation
{
    static void Main()
    {
        Console.Write("Enter your weight in kilograms on the Earth:");
        double weightOnEarth = double.Parse(Console.ReadLine());

        Console.WriteLine("If you were on the Moon, you would be {0:f3} kilograms.", weightOnEarth * 0.17);
        
    }
}

