/*  Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.*/

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year to check if it is leap:");
        ushort year = ushort.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Year {0} is leap year.", year);
        }
        else
        {
            Console.WriteLine("Year {0} is NOT leap year.", year);
        }
    }
}
