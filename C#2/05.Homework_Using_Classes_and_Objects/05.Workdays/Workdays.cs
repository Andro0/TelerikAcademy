/*  Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of 
    public holidays specified preliminary as array. */

using System;
using System.Linq;

class Workdays
{
    private DateTime now;
    private DateTime futureDate;
    //Holidays 2015
    private DateTime[] publicHolidays = new DateTime[] {
        new DateTime( DateTime.Now.Year, 1, 1),
        new DateTime( DateTime.Now.Year, 1, 2),
        new DateTime( DateTime.Now.Year, 3, 2),
        new DateTime( DateTime.Now.Year, 3, 3),
        new DateTime( DateTime.Now.Year, 4, 10),
        new DateTime( DateTime.Now.Year, 4, 13),
        new DateTime( DateTime.Now.Year, 6, 1),
        new DateTime( DateTime.Now.Year, 6, 6),
        new DateTime( DateTime.Now.Year, 9, 21),
        new DateTime( DateTime.Now.Year, 9, 22),
        new DateTime( DateTime.Now.Year, 12, 24),
        new DateTime( DateTime.Now.Year, 12, 25),
        new DateTime( DateTime.Now.Year, 12, 31),
    };
    public Workdays(DateTime futureDate)
    {
        this.now = DateTime.Now;
        this.futureDate = futureDate;
    }

    public int CountWorkdays()
    {
        int countDays = 0;

        while (this.now < this.futureDate)
        {
            if (now.DayOfWeek.ToString().Equals("Saturday") || now.DayOfWeek.ToString().Equals("Sunday"))
            {
                this.now = this.now.AddDays(1);
            }
            else if (isHoliday())
            {
                this.now = this.now.AddDays(1);
            }
            else
            {
                countDays++;
                this.now = this.now.AddDays(1);
            }
        }
        return countDays;
    }

    public bool isHoliday()
    {
        for (int i = 0; i < publicHolidays.Length; i++)
        {
            if (this.now.Month == this.publicHolidays[i].Month && this.now.Day == this.publicHolidays[i].Day)
            {
                return true;
            }
        }
        return false;
    }
    static void Main()
    {

        Console.Write("Enter the month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the day: ");
        int day = int.Parse(Console.ReadLine());

        Workdays workdays = new Workdays(new DateTime(DateTime.Now.Year, month, day));
        Console.WriteLine("You have {0} workdays from now to {1}.{2}.{3}", workdays.CountWorkdays(), day, month, DateTime.Now.Year);
        Console.WriteLine();

    }
}
