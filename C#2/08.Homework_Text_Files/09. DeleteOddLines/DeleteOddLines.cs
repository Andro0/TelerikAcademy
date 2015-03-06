/*  Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
 */

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            string path = @"..\..\09.deleteOddLines.txt";

            try
            {
                StringBuilder result = new StringBuilder();

                using (StreamReader reader = File.OpenText(path))
                {
                    string currentLine;
                    int counter = 0;

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        if (counter % 2 == 1)
                        {
                            result.Append(currentLine + "\r\n");
                        }
                        counter++;
                    }
                }

                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine(result.ToString());
                }
                Console.WriteLine("The file {0} has been modified.",
                                    Path.GetFileName(path));

                Console.WriteLine("File is in directory--> " +
                                    Path.GetFullPath(path).Replace(Path.GetFileName(path), String.Empty));


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
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
