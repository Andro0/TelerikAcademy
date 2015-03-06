/*  Write a program that finds how many times a sub-string is contained in a given text 
    (perform case insensitive search).
    
    Example:
    The target sub-string is in
    The text is as follows: We are living in an yellow submarine. We don't have anything else.
    inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. 
 */

using System;
using System.Linq;

class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter text:");
        string text = Console.ReadLine();
        Console.Write("Enter target substring to search:");
        string target = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (string.Compare(text[i].ToString(), target[0].ToString(), true) == 0)
            {
                if (text.Length - i < target.Length)
                {
                    break;
                }
                string textSub = text.Substring(i, target.Length);
                if (string.Compare(textSub, target, true) == 0)
                {
                    count++;
                    i = i + target.Length;
                }
            }
        }
        Console.WriteLine(count);
    }
}