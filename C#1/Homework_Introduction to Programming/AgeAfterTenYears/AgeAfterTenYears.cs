//Program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birth date in format: dd/MM/yyyy: ");
        string[] yourBirth = Console.ReadLine().Split(new char[] { ' ', '/', ',', '-', '.', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        string format = "dd/MM/yyyy";
        DateTime birthDate = DateTime.ParseExact(string.Join("/", yourBirth), format, System.Globalization.CultureInfo.InvariantCulture);
        int ages = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now.AddYears(-ages) < birthDate) --ages;
        Console.WriteLine("Now you are {0} years old", ages);
        Console.WriteLine("At this date, after ten years you will be {0} years old", ages + 10);
    }
}

