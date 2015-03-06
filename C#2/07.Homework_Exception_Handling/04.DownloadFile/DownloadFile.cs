/*  Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
 */

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient wc = null;
        string errorMessage = null;
        Console.WriteLine("Enter Internet address from where to download the file:");
        string url = Console.ReadLine();//http://telerikacademy.com/Content/Images/news-img01.png

        try
        {
            wc = new WebClient();
            wc.DownloadFile(url, @"url");
            wc.DownloadFile(url, @"Ninja.png");
            Console.WriteLine("The file is saved at {0}.", Directory.GetCurrentDirectory());
        }
        catch (WebException we)
        {
            errorMessage = we.Message;
        }
        catch (NotSupportedException nse)
        {
            errorMessage = nse.Message;
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
        finally
        {
            if (errorMessage != null) Console.WriteLine(errorMessage);
        }
    }
}