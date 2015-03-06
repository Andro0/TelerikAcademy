/*  Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.*/

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        string text = Console.ReadLine(); //"I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

        string format = "d.M.yyyy";
        CultureInfo provider = Thread.CurrentThread.CurrentCulture;

        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            try
            {
                DateTime check = DateTime.ParseExact(match.ToString(), format, provider);
                Console.WriteLine(check.ToShortDateString());
            }
            catch (FormatException)
            {
                continue;
            }
        }

    }
}
