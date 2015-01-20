//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;
class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        Console.Write("Enter real number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter real number b: ");
        double b = double.Parse(Console.ReadLine());

        double difference = a - b;
        if (Math.Abs(difference) >= eps)
        {
            Console.WriteLine("Equal with precision eps=0.000001 is {0}.",false);
        }
        else
        {
            Console.WriteLine("Equal with precision eps=0.000001 is {0}.",true);
        }

        Console.WriteLine("Difference betwen the two real numbers is {0}", Math.Abs(difference));

    }
}

