/*  A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range
    [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above
    or invalid time if the time cannot be parsed.*/

using System;
class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time in format \"hh:mm tt\"--->");
        string beerTime = Console.ReadLine();
        string format = "hh:mm tt";
        DateTime time = Convert.ToDateTime(beerTime);
        DateTime start = Convert.ToDateTime("01:00 PM");
        DateTime end = Convert.ToDateTime("02:59 AM");

        if (beerTime == time.ToString(format))
        {

            int i = DateTime.Compare(time, start);
            int j = DateTime.Compare(time, end);
            if (i >= 0 || j <= 0)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("NON-Beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format!!!");
        }
               
    }
}