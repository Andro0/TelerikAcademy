﻿//  Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.


using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Enter text from HTML file:");
        string sample = Console.ReadLine(); //"<html><head><title>News</title></ head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        string title = GetTitle(sample);
        if (String.IsNullOrWhiteSpace(title))
        {
            title = "No title";
        }
        string body = GetText(sample);
        Console.WriteLine("Title:{0}\nText:{1}", title, body);

    }
    private static string GetText(string sample)
    {
        string text = Regex.Match(sample, @"<\s*body\s*>.*?<\s*/\s*body\s*>").ToString();
        return Regex.Replace(text, @"<.*?>", String.Empty);
    }

    private static string GetTitle(string sample)
    {
        string head = Regex.Match(sample, @"<\s*head\s*>.*?<\s*/\s*head\s*>").ToString();
        if (head == String.Empty || !head.Contains("title"))
        {
            return string.Empty;
        }

        string title = Regex.Match(head, @"<\s*title\s*>.*?<\s*/\s*title\s*>").ToString();
        title = Regex.Replace(title, @"<\s*title\s*>", String.Empty);
        title = Regex.Replace(title, @"<\s*/\s*title\s*>", String.Empty);

        return title.Trim();
    }
}
