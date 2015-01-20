/*  First name, Last name, Age (0...100), Gender (m or f), Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using
    appropriate primitive data types. Use descriptive names. Print the data at the console. */

using System;
class EmployeeData
{
    static void Main()
    {
        string firstName = "Kirelet";
        string lastName = "Ymedaca";
        byte ages = 100;
        char gender = 'm';
        ulong personId = 8306112507;
        ulong employeeNum = 27569999;

        Console.WriteLine("Employee Information");
        Console.WriteLine("".PadLeft(30, '-'));
        Console.Write("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\n" +
            "Personal ID number: {4}\nUniqe employee number: {5}\n",
            firstName, lastName, ages, gender, personId, employeeNum);

    }
}

