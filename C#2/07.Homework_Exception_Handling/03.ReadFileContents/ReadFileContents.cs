/*  Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;

class ReadFileContents
{
    static void Main()
    {
        string errorMessage = null;
        Console.Write("Enter file path to read text:");
        string filePath = Console.ReadLine();//D:\TelerikCourseFiles\exception1.txt

        try
        {
            Console.WriteLine(FileToString(filePath));
        }
        catch (ArgumentNullException ane)
        {
            errorMessage = ane.Message;
        }
        catch (ArgumentException ae)
        {
            errorMessage = ae.Message;
        }
        catch (PathTooLongException ptle)
        {
            errorMessage = ptle.Message;
        }
        catch (DirectoryNotFoundException dnfe)
        {
            errorMessage = dnfe.Message;
        }
        catch (FileNotFoundException fnfe)
        {
            errorMessage = fnfe.Message;
        }
        catch (IOException ioe)
        {
            errorMessage = ioe.Message;
        }
        catch (UnauthorizedAccessException uae)
        {
            errorMessage = uae.Message;
        }
        catch (NotSupportedException nse)
        {
            errorMessage = nse.Message;
        }
        catch (SecurityException se)
        {
            errorMessage = se.Message;
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
        finally
        {
            if (errorMessage != null)
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
    
    private static string FileToString(string filePath)
    {
        string toString = File.ReadAllText(filePath, Encoding.UTF8);
        return toString;
    }

}
