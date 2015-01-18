//Application that prints your first and last name, each at a separate line.
using System;
class PrintFirstLastName
{
    static void Main()
    {
        Console.Write("Enter your first name:"); //Ask you to enter your first name

        //Read your first name from the Console and assign it to variable firstName of type string
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name:"); //Ask you to enter your last name

        //Read your last name from the Console and assign it to variable lastName of type string
        string lastName = Console.ReadLine();

        Console.Write("Your first name is:"); //Print "Your first name is:"
        Console.WriteLine(firstName);  //Print your first name on the same line and goes to next line

        Console.Write("Your last name is:");  //Print "Your last name is:"
        Console.WriteLine(lastName);  //Print your last name on the same line

    }
}

