/*  Write a program that reads a date and time given in the format: day.month.year hour:minute:second and
    prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

using System;
using System.Globalization;
using System.Threading;
class DateInBulgarian
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        string format = "d.M.yyyy H:m:s"; //1.3.2015 23:30:11
        Console.Write("Enter date in format (dd.MM.yyyy HH:mm:ss): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.GetCultureInfo("BG-bg"));
        date = date.AddMinutes(390);
        Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"), CultureInfo.GetCultureInfo("BG-bg"));
    }
}
