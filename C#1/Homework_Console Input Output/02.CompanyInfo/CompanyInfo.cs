/*  A company has name, address, phone number, fax number, web site and manager.
    The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console. */

using System;
class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter company information".PadLeft(30));
        Console.WriteLine("".PadLeft(40, '-'));

        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number:");
        string companyPhone = Console.ReadLine();
        Console.Write("Fax number:");
        string fax = Console.ReadLine();
        Console.Write("Web site:");
        string website = Console.ReadLine();
        Console.Write("Manager first name:");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string lastName = Console.ReadLine();
        Console.Write("Manager age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone:");
        string phone = Console.ReadLine();

        Console.WriteLine("".PadLeft(40, '-'));
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: " + ((fax.Length == 0) ? "(no fax)\n" : "{3}\n") +
            "Web site: {4}\nManager: {5} {6} (age: {7}, tel. {8})\n",
            companyName, companyAddress, companyPhone, fax, website, firstName, lastName, age, phone);

    }
}

