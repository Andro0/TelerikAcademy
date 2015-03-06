/*  Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
 */

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string writeFilePath = @"..\..\03.textWithLineNumbers.txt";
            string readFilePath = @"..\..\03.textWithoutLineNumbers.txt";
            try
            {
                StringBuilder result = new StringBuilder();
                using (StreamReader reader = new StreamReader(readFilePath))
                {
                    string line;
                    int lineNumber = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        result.AppendLine(String.Format("{0,-5:D3}{1}", lineNumber, line));
                        ++lineNumber;
                    }

                    if (result.Length == 0)
                    {
                        result.AppendLine("Sorry, no text!");
                    }

                    File.WriteAllLines(writeFilePath, result.ToString().Split('\n'));
                    Console.WriteLine("Directory: " +
                        Path.GetFullPath(readFilePath)
                        .Replace(Path.GetFileName(readFilePath), String.Empty));

                    Console.WriteLine("File without line numbers: " +
                        Path.GetFileNameWithoutExtension(readFilePath));

                    Console.WriteLine("File with line numbers created: "
                        + Path.GetFileNameWithoutExtension(writeFilePath));
                }
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileLoadException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (EndOfStreamException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
