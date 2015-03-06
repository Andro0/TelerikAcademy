/*  Write a program that reads two dates in the format: day.month.year and calculates the number
    of days between them.
 */

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        string format = "d.M.yyyy";
        Console.Write("Enter first date in format d.M.yyyy:");
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        Console.Write("Enter second date in format d.M.yyyy:");
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        Console.WriteLine("Distance:{0}", Math.Abs((startDate - endDate).Days));


    }

}
