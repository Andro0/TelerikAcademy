/*  Write a program that replaces in a HTML document given as string all the tags
    <a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        Console.Write("Enter HTML document given as string:");
        string htmlText = Console.ReadLine();

        string newText = Regex.Replace(htmlText, @"<a href=""", "[URL=");
        newText = Regex.Replace(newText, @""">", "] ");
        newText = Regex.Replace(newText, "</a>", "[/URL]");
        Console.WriteLine();
        Console.WriteLine("New text with replaced tags is:{0}", newText);

    }
}

