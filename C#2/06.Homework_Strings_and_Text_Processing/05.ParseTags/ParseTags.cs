/*  You are given a text. Write a program that changes the text in all regions surrounded by the 
    tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.
 */

using System;

class ParseTags
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        int startTagIndex = 0;
        int endTagIndex = 0;
        while (startTagIndex < text.LastIndexOf(endTag))
        {
            startTagIndex = text.IndexOf(startTag, startTagIndex + 1);
            endTagIndex = text.IndexOf(endTag, endTagIndex + 1);
            string midTagUpper = text.Substring(startTagIndex + 8, endTagIndex - startTagIndex - 8).ToUpper();
            string removeTagsAndBetween = text.Substring(startTagIndex, endTagIndex - startTagIndex + 9);
            text = text.Replace(removeTagsAndBetween, midTagUpper);
        }
        Console.WriteLine("Formatted text is:{0}", text);
    }
}
