/*  Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0…9, a…z, A…Z, _.
 */

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace PrefixTest
{
    class PrefixTest
    {
        static void Main()
        {
            string inputPath = @"..\..\11.inputPrefix.txt";
            string resultPath = @"..\..\11.outputPrefix.txt";

            try
            {
                StringBuilder result = new StringBuilder();

                using (StreamReader reader = new StreamReader(inputPath))
                {
                    string currentLine;
                    while (!reader.EndOfStream)
                    {
                        currentLine = reader.ReadLine();
                        string[] separatedWords = currentLine
                            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
                            .ToArray();

                        result.AppendLine(String.Join(" ", separatedWords));
                    }
                }

                using (StreamWriter writer = new StreamWriter(resultPath))
                {
                    writer.Write(result.ToString());
                }

                Console.WriteLine("The file {0} has been created.",
                                    Path.GetFileName(resultPath));

                Console.WriteLine("File is in directory--> " +
                                    Path.GetFullPath(resultPath).Replace(Path.GetFileName(resultPath), String.Empty));


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
