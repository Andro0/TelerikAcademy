/*  Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and
    extracts from it the [protocol], [server] and [resource] elements.
*/

using System;

class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL address:");
        string url = Console.ReadLine();
        try
        {
            int protokolIndex = url.IndexOf(':');
            string protocol = url.Substring(0, protokolIndex);
            int serverIndex = url.IndexOf('/', protokolIndex + 3);
            string server = url.Substring(protokolIndex + 3, serverIndex - protokolIndex - 3);
            string resource = url.Substring(serverIndex + 1);
            Console.WriteLine("[protocol]=\"{0}\"", protocol);
            Console.WriteLine("[server]=\"{0}\"", server);
            Console.WriteLine("[resource]=\"{0}\"", resource);
        }
        catch (ArgumentException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The URL is incorrect !!!");
        }
    }
}
