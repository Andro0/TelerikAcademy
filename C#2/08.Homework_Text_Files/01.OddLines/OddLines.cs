//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Linq;
using System.Text;

class OddLines
{
    static void Main()
    {
        string path = @"..\..\01.Textfile.txt";
        Console.Title = "Odd Lines In File";
        try
        {
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                int rowCount = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (rowCount % 2 != 0)
                    {
                        Console.WriteLine("Row {0}: {1}", rowCount, line);
                    }
                    line = reader.ReadLine();
                    ++rowCount;
                }
            }
        }
        catch (System.Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
        finally
        {
            Console.WriteLine();
        }
    }

}
