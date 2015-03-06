/*  Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        //Hi! My email @ yahoo is myemail@yahoo.com. I also have 101mailGO@mail_provider.co.uk! You can write me to my work-email too:work_mail@privider.at.my.work
        string pattern = @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
       + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
         + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
       + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

        MatchCollection matches = Regex.Matches(text, pattern);
        Console.WriteLine("E-mails includes in text");
        Console.WriteLine(new string('-', 25));
        foreach (Match match in matches)
        {
            Console.WriteLine("{0}", match);
        }
        Console.WriteLine();

    }
}
